#![allow(unused_imports)]

use std::env;
use std::time::{Duration, SystemTime};
use std::net::SocketAddr;

use futures::stream::Stream;
use futures::stream::StreamExt;
use futures_util::pin_mut;

use tracing::{trace, debug, info, warn, error, span};
use tracing::{trace_span, debug_span, info_span, warn_span, error_span};
use tracing::{Level, instrument};
use tracing_futures::Instrument;
use tracing_subscriber;

use tokio::time;

use tonic::{
    transport::{Identity, Server, ServerTlsConfig},
    Request, Response, Status,
};

use async_stream::try_stream;


pub mod test_grpc {
    tonic::include_proto!("test.grpc");
}

use test_grpc::{
    test_server::{Test, TestServer},
    Empty, Ping, Pong
};

struct TestService {}

#[tonic::async_trait]
impl Test for TestService {

    type OpenTestStreamStream = std::pin::Pin<Box<dyn Stream<Item=Result<Empty, tonic::Status>> + Send + Sync + 'static>>;

    async fn open_test_stream(
        &self,
        _request: tonic::Request<test_grpc::Empty>,
    ) -> Result<tonic::Response<Self::OpenTestStreamStream>, tonic::Status> {
        println!("Opened test stream");

        let s = try_stream!{
            let interval = time::interval(Duration::from_secs(2));
            pin_mut!(interval);

            while let Some(interval) = interval.next().await {
                yield test_grpc::Empty{};
            }
        };

        Ok(tonic::Response::new(Box::pin(s)))
    }

    async fn send_ping(
        &self,
        request: Request<Ping>
    ) -> Result<Response<Pong>, Status> {
        println!("Got a Ping request: {:?}", request);

        let now = SystemTime::now().duration_since(SystemTime::UNIX_EPOCH).unwrap();
        let send_timestamp: u64 = (now.as_secs() as u64) * 1000000000u64 + (now.subsec_nanos() as u64);

        let reply = test_grpc::Pong {
            epoch_send_timestamp_ns: send_timestamp
        };

        Ok(Response::new(reply))
    }
}

async fn run() -> Result<(), Box<dyn std::error::Error>> {
    let test_service = TestService {};

    let address = env::var("LISTEN_ADDRESS").unwrap_or("0.0.0.0:50051".to_string());
    println!("gRPC service listening on: {}", &address);
    let addr: SocketAddr = address.parse().unwrap();

    let mut builder = Server::builder();

    let use_tls = match env::var("USE_TLS") { Ok(_) => true, _ => false };
    if use_tls {
        info!("Running with TLS enabled");
        let cert = tokio::fs::read("../secrets/test.crt").await?;
        let key = tokio::fs::read("../secrets/test.key").await?;
        let identity = Identity::from_pem(cert, key);
        builder = builder.tls_config(ServerTlsConfig::new().identity(identity));
    } else {
        warn!("Running with TLS disabled");
    }

    builder
        .trace_fn(|_| tracing::info_span!("grpc_service"))
        .add_service(TestServer::new(test_service))
        .serve(addr)
        .await?;

    Ok(())
}

#[tokio::main]
async fn main() -> Result<(), Box<dyn std::error::Error>> {
    tracing_subscriber::fmt::init();
    run().instrument(trace_span!("run")).await
}
