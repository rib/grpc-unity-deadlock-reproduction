#!/bin/bash

# run this from WSL on Windows

grpc.tools/tools/windows_x64/protoc.exe --plugin=protoc-gen-grpc=grpc.tools/tools/windows_x64/grpc_csharp_plugin.exe --csharp_out=../Assets/Scripts/proto --grpc_out=../Assets/Scripts/proto test.proto
