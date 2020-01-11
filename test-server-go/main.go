package main

import (
	"fmt"
	"net"
	"flag"
	"time"
	"log"

	"golang.org/x/net/context"
	"google.golang.org/grpc"
	"google.golang.org/grpc/credentials"

	pb "test.co/test-grpc/grpc"
)

type testServer struct {
	pb.UnimplementedTestServer
}

func (s *testServer) SendPing(ctx context.Context, req *pb.Ping) (*pb.Pong, error) {
	log.Printf("Received ping: %v\n", req);
	return &pb.Pong{EpochSendTimestampNS: uint64(time.Now().UnixNano())}, nil
}

func (s *testServer) OpenTestStream(req *pb.Empty, stream pb.Test_OpenTestStreamServer) error {
	println("Opened test stream")

	for i := 0; i < 60; i++ {
		empty := pb.Empty{};
		err := stream.Send(&empty)
		if err != nil {
			log.Printf("Error sending Empty{}: %v\n", err)
			return err
		}
		println("Streamed empty item")
		time.Sleep(1 * time.Second)
	}

	return nil
}

var port = flag.Int("port", 50051, "the port to serve on")
var useTls = flag.Bool("use_tls", false, "use TLS")

func main() {
	flag.Parse()

	var grpcServer *grpc.Server = nil

	if *useTls {
		println("Using TLS")

		certFile := "../secrets/test.crt"
		keyFile := "../secrets/test.key"

		creds, err := credentials.NewServerTLSFromFile(certFile, keyFile)
		if err != nil {
			log.Fatalf("Failed to load credentials");
		}

		grpcServer = grpc.NewServer(grpc.Creds(creds))
	} else {
		println("Not using TLS")
		grpcServer = grpc.NewServer()
	}
	defer grpcServer.Stop()

	lis, err := net.Listen("tcp", fmt.Sprintf(":%d", *port))
	if err != nil {
		log.Fatalf("Failed to listen")
	}
	log.Printf("Listening on port %d\n", *port)

	srv := testServer{}
	pb.RegisterTestServer(grpcServer, &srv)

	grpcServer.Serve(lis)
}