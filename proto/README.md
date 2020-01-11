Update the generated protobuf code by running:

```bash
grpc.tools/tools/windows_x64/protoc.exe \
    '--plugin=protoc-gen-grpc=grpc.tools/tools/windows_x64/grpc_csharp_plugin.exe' \
    --csharp_out=../Assets/Scripts/proto \
    --grpc_out=../Assets/Scripts/proto \
    test.proto
```

C# gRPC codegen is handled by a plugin that's distributed as part of the Grpc.Tools
NuGet package. We don't want to require the separate installation of this package
so we just include a copy as part of this repo.

To update the Grpc.Tools snapshot:
```bash
wget https://www.nuget.org/api/v2/package/Grpc.Tools/2.25.0 -O grpc.tool.zip
mkdir grpc.tools
cd grpc.tools
unzip ../grpc.tools.zip
```

