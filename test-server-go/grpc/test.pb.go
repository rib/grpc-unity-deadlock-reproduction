// Code generated by protoc-gen-go. DO NOT EDIT.
// source: test.proto

package test_grpc

import (
	context "context"
	fmt "fmt"
	proto "github.com/golang/protobuf/proto"
	grpc "google.golang.org/grpc"
	codes "google.golang.org/grpc/codes"
	status "google.golang.org/grpc/status"
	math "math"
)

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = fmt.Errorf
var _ = math.Inf

// This is a compile-time assertion to ensure that this generated file
// is compatible with the proto package it is being compiled against.
// A compilation error at this line likely means your copy of the
// proto package needs to be updated.
const _ = proto.ProtoPackageIsVersion3 // please upgrade the proto package

type Empty struct {
	XXX_NoUnkeyedLiteral struct{} `json:"-"`
	XXX_unrecognized     []byte   `json:"-"`
	XXX_sizecache        int32    `json:"-"`
}

func (m *Empty) Reset()         { *m = Empty{} }
func (m *Empty) String() string { return proto.CompactTextString(m) }
func (*Empty) ProtoMessage()    {}
func (*Empty) Descriptor() ([]byte, []int) {
	return fileDescriptor_c161fcfdc0c3ff1e, []int{0}
}

func (m *Empty) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_Empty.Unmarshal(m, b)
}
func (m *Empty) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_Empty.Marshal(b, m, deterministic)
}
func (m *Empty) XXX_Merge(src proto.Message) {
	xxx_messageInfo_Empty.Merge(m, src)
}
func (m *Empty) XXX_Size() int {
	return xxx_messageInfo_Empty.Size(m)
}
func (m *Empty) XXX_DiscardUnknown() {
	xxx_messageInfo_Empty.DiscardUnknown(m)
}

var xxx_messageInfo_Empty proto.InternalMessageInfo

type Ping struct {
	EpochSendTimestampNS uint64   `protobuf:"varint,1,opt,name=epochSendTimestampNS,proto3" json:"epochSendTimestampNS,omitempty"`
	XXX_NoUnkeyedLiteral struct{} `json:"-"`
	XXX_unrecognized     []byte   `json:"-"`
	XXX_sizecache        int32    `json:"-"`
}

func (m *Ping) Reset()         { *m = Ping{} }
func (m *Ping) String() string { return proto.CompactTextString(m) }
func (*Ping) ProtoMessage()    {}
func (*Ping) Descriptor() ([]byte, []int) {
	return fileDescriptor_c161fcfdc0c3ff1e, []int{1}
}

func (m *Ping) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_Ping.Unmarshal(m, b)
}
func (m *Ping) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_Ping.Marshal(b, m, deterministic)
}
func (m *Ping) XXX_Merge(src proto.Message) {
	xxx_messageInfo_Ping.Merge(m, src)
}
func (m *Ping) XXX_Size() int {
	return xxx_messageInfo_Ping.Size(m)
}
func (m *Ping) XXX_DiscardUnknown() {
	xxx_messageInfo_Ping.DiscardUnknown(m)
}

var xxx_messageInfo_Ping proto.InternalMessageInfo

func (m *Ping) GetEpochSendTimestampNS() uint64 {
	if m != nil {
		return m.EpochSendTimestampNS
	}
	return 0
}

type Pong struct {
	EpochSendTimestampNS uint64   `protobuf:"varint,1,opt,name=epochSendTimestampNS,proto3" json:"epochSendTimestampNS,omitempty"`
	XXX_NoUnkeyedLiteral struct{} `json:"-"`
	XXX_unrecognized     []byte   `json:"-"`
	XXX_sizecache        int32    `json:"-"`
}

func (m *Pong) Reset()         { *m = Pong{} }
func (m *Pong) String() string { return proto.CompactTextString(m) }
func (*Pong) ProtoMessage()    {}
func (*Pong) Descriptor() ([]byte, []int) {
	return fileDescriptor_c161fcfdc0c3ff1e, []int{2}
}

func (m *Pong) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_Pong.Unmarshal(m, b)
}
func (m *Pong) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_Pong.Marshal(b, m, deterministic)
}
func (m *Pong) XXX_Merge(src proto.Message) {
	xxx_messageInfo_Pong.Merge(m, src)
}
func (m *Pong) XXX_Size() int {
	return xxx_messageInfo_Pong.Size(m)
}
func (m *Pong) XXX_DiscardUnknown() {
	xxx_messageInfo_Pong.DiscardUnknown(m)
}

var xxx_messageInfo_Pong proto.InternalMessageInfo

func (m *Pong) GetEpochSendTimestampNS() uint64 {
	if m != nil {
		return m.EpochSendTimestampNS
	}
	return 0
}

func init() {
	proto.RegisterType((*Empty)(nil), "test.grpc.Empty")
	proto.RegisterType((*Ping)(nil), "test.grpc.Ping")
	proto.RegisterType((*Pong)(nil), "test.grpc.Pong")
}

func init() { proto.RegisterFile("test.proto", fileDescriptor_c161fcfdc0c3ff1e) }

var fileDescriptor_c161fcfdc0c3ff1e = []byte{
	// 161 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0xff, 0xe2, 0xe2, 0x2a, 0x49, 0x2d, 0x2e,
	0xd1, 0x2b, 0x28, 0xca, 0x2f, 0xc9, 0x17, 0xe2, 0x04, 0xb3, 0xd3, 0x8b, 0x0a, 0x92, 0x95, 0xd8,
	0xb9, 0x58, 0x5d, 0x73, 0x0b, 0x4a, 0x2a, 0x95, 0xac, 0xb8, 0x58, 0x02, 0x32, 0xf3, 0xd2, 0x85,
	0x8c, 0xb8, 0x44, 0x52, 0x0b, 0xf2, 0x93, 0x33, 0x82, 0x53, 0xf3, 0x52, 0x42, 0x32, 0x73, 0x53,
	0x8b, 0x4b, 0x12, 0x73, 0x0b, 0xfc, 0x82, 0x25, 0x18, 0x15, 0x18, 0x35, 0x58, 0x82, 0xb0, 0xca,
	0x81, 0xf5, 0xe6, 0x93, 0xa7, 0xd7, 0x28, 0x87, 0x8b, 0x25, 0x24, 0xb5, 0xb8, 0x44, 0xc8, 0x8c,
	0x8b, 0xcf, 0xbf, 0x20, 0x35, 0x0f, 0xc4, 0x0e, 0x2e, 0x29, 0x4a, 0x4d, 0xcc, 0x15, 0x12, 0xd0,
	0x83, 0x3b, 0x53, 0x0f, 0xec, 0x46, 0x29, 0x0c, 0x11, 0x03, 0x46, 0x21, 0x1d, 0x2e, 0x0e, 0x90,
	0x91, 0x60, 0xb7, 0xf3, 0x23, 0xc9, 0x83, 0x04, 0xa4, 0x50, 0x04, 0xf2, 0xf3, 0xd2, 0x93, 0xd8,
	0xc0, 0x01, 0x60, 0x0c, 0x08, 0x00, 0x00, 0xff, 0xff, 0x99, 0x7f, 0x7b, 0x68, 0x0e, 0x01, 0x00,
	0x00,
}

// Reference imports to suppress errors if they are not otherwise used.
var _ context.Context
var _ grpc.ClientConn

// This is a compile-time assertion to ensure that this generated file
// is compatible with the grpc package it is being compiled against.
const _ = grpc.SupportPackageIsVersion4

// TestClient is the client API for Test service.
//
// For semantics around ctx use and closing/ending streaming RPCs, please refer to https://godoc.org/google.golang.org/grpc#ClientConn.NewStream.
type TestClient interface {
	OpenTestStream(ctx context.Context, in *Empty, opts ...grpc.CallOption) (Test_OpenTestStreamClient, error)
	SendPing(ctx context.Context, in *Ping, opts ...grpc.CallOption) (*Pong, error)
}

type testClient struct {
	cc *grpc.ClientConn
}

func NewTestClient(cc *grpc.ClientConn) TestClient {
	return &testClient{cc}
}

func (c *testClient) OpenTestStream(ctx context.Context, in *Empty, opts ...grpc.CallOption) (Test_OpenTestStreamClient, error) {
	stream, err := c.cc.NewStream(ctx, &_Test_serviceDesc.Streams[0], "/test.grpc.Test/OpenTestStream", opts...)
	if err != nil {
		return nil, err
	}
	x := &testOpenTestStreamClient{stream}
	if err := x.ClientStream.SendMsg(in); err != nil {
		return nil, err
	}
	if err := x.ClientStream.CloseSend(); err != nil {
		return nil, err
	}
	return x, nil
}

type Test_OpenTestStreamClient interface {
	Recv() (*Empty, error)
	grpc.ClientStream
}

type testOpenTestStreamClient struct {
	grpc.ClientStream
}

func (x *testOpenTestStreamClient) Recv() (*Empty, error) {
	m := new(Empty)
	if err := x.ClientStream.RecvMsg(m); err != nil {
		return nil, err
	}
	return m, nil
}

func (c *testClient) SendPing(ctx context.Context, in *Ping, opts ...grpc.CallOption) (*Pong, error) {
	out := new(Pong)
	err := c.cc.Invoke(ctx, "/test.grpc.Test/SendPing", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

// TestServer is the server API for Test service.
type TestServer interface {
	OpenTestStream(*Empty, Test_OpenTestStreamServer) error
	SendPing(context.Context, *Ping) (*Pong, error)
}

// UnimplementedTestServer can be embedded to have forward compatible implementations.
type UnimplementedTestServer struct {
}

func (*UnimplementedTestServer) OpenTestStream(req *Empty, srv Test_OpenTestStreamServer) error {
	return status.Errorf(codes.Unimplemented, "method OpenTestStream not implemented")
}
func (*UnimplementedTestServer) SendPing(ctx context.Context, req *Ping) (*Pong, error) {
	return nil, status.Errorf(codes.Unimplemented, "method SendPing not implemented")
}

func RegisterTestServer(s *grpc.Server, srv TestServer) {
	s.RegisterService(&_Test_serviceDesc, srv)
}

func _Test_OpenTestStream_Handler(srv interface{}, stream grpc.ServerStream) error {
	m := new(Empty)
	if err := stream.RecvMsg(m); err != nil {
		return err
	}
	return srv.(TestServer).OpenTestStream(m, &testOpenTestStreamServer{stream})
}

type Test_OpenTestStreamServer interface {
	Send(*Empty) error
	grpc.ServerStream
}

type testOpenTestStreamServer struct {
	grpc.ServerStream
}

func (x *testOpenTestStreamServer) Send(m *Empty) error {
	return x.ServerStream.SendMsg(m)
}

func _Test_SendPing_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(Ping)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(TestServer).SendPing(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/test.grpc.Test/SendPing",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(TestServer).SendPing(ctx, req.(*Ping))
	}
	return interceptor(ctx, in, info, handler)
}

var _Test_serviceDesc = grpc.ServiceDesc{
	ServiceName: "test.grpc.Test",
	HandlerType: (*TestServer)(nil),
	Methods: []grpc.MethodDesc{
		{
			MethodName: "SendPing",
			Handler:    _Test_SendPing_Handler,
		},
	},
	Streams: []grpc.StreamDesc{
		{
			StreamName:    "OpenTestStream",
			Handler:       _Test_OpenTestStream_Handler,
			ServerStreams: true,
		},
	},
	Metadata: "test.proto",
}
