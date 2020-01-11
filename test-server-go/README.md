
E.g. Run like:

```bash
go run main.go -port 50051 -use_tls=false
```


To re-generate the protobuf code if test.proto changed:

```bash
protoc --go_out=plugins=grpc:grpc/ -I ../proto ../proto/test.proto
```
