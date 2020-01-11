use std::env;
use std::path::Path;
use std::process::Command;

fn compile_server_protos(protos: &[&Path], includes: &[&Path]) -> Result<(), Box<dyn std::error::Error>>
{
    for proto in protos.iter() {
        println!("cargo:rerun-if-changed={}", proto.to_str().unwrap());
    }
    tonic_build::configure()
        .build_client(false)
        .compile(protos, includes)?;
    Ok(())
}

fn main() -> Result<(), Box<dyn std::error::Error>> {
    let manifest_dir_env = env::var("CARGO_MANIFEST_DIR").expect("CARGO_MANIFEST_DIR evironment variable unset");

    let test_proto_dir = Path::new(&manifest_dir_env).join("../proto");
    let test_proto = Path::new(&test_proto_dir).join(Path::new("test.proto"));
    compile_server_protos(&[&test_proto], &[&test_proto_dir])?;

    Ok(())
}