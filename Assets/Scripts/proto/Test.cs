// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: test.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Test.Grpc {

  /// <summary>Holder for reflection information generated from test.proto</summary>
  public static partial class TestReflection {

    #region Descriptor
    /// <summary>File descriptor for test.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgp0ZXN0LnByb3RvEgl0ZXN0LmdycGMiBwoFRW1wdHkiJAoEUGluZxIcChRl",
            "cG9jaFNlbmRUaW1lc3RhbXBOUxgBIAEoBCIkCgRQb25nEhwKFGVwb2NoU2Vu",
            "ZFRpbWVzdGFtcE5TGAEgASgEMmwKBFRlc3QSNgoOT3BlblRlc3RTdHJlYW0S",
            "EC50ZXN0LmdycGMuRW1wdHkaEC50ZXN0LmdycGMuRW1wdHkwARIsCghTZW5k",
            "UGluZxIPLnRlc3QuZ3JwYy5QaW5nGg8udGVzdC5ncnBjLlBvbmdiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Test.Grpc.Empty), global::Test.Grpc.Empty.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Test.Grpc.Ping), global::Test.Grpc.Ping.Parser, new[]{ "EpochSendTimestampNS" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Test.Grpc.Pong), global::Test.Grpc.Pong.Parser, new[]{ "EpochSendTimestampNS" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Empty : pb::IMessage<Empty> {
    private static readonly pb::MessageParser<Empty> _parser = new pb::MessageParser<Empty>(() => new Empty());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Empty> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Test.Grpc.TestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Empty() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Empty(Empty other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Empty Clone() {
      return new Empty(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Empty);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Empty other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Empty other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  public sealed partial class Ping : pb::IMessage<Ping> {
    private static readonly pb::MessageParser<Ping> _parser = new pb::MessageParser<Ping>(() => new Ping());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Ping> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Test.Grpc.TestReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Ping() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Ping(Ping other) : this() {
      epochSendTimestampNS_ = other.epochSendTimestampNS_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Ping Clone() {
      return new Ping(this);
    }

    /// <summary>Field number for the "epochSendTimestampNS" field.</summary>
    public const int EpochSendTimestampNSFieldNumber = 1;
    private ulong epochSendTimestampNS_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong EpochSendTimestampNS {
      get { return epochSendTimestampNS_; }
      set {
        epochSendTimestampNS_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Ping);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Ping other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EpochSendTimestampNS != other.EpochSendTimestampNS) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EpochSendTimestampNS != 0UL) hash ^= EpochSendTimestampNS.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (EpochSendTimestampNS != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(EpochSendTimestampNS);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EpochSendTimestampNS != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(EpochSendTimestampNS);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Ping other) {
      if (other == null) {
        return;
      }
      if (other.EpochSendTimestampNS != 0UL) {
        EpochSendTimestampNS = other.EpochSendTimestampNS;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            EpochSendTimestampNS = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Pong : pb::IMessage<Pong> {
    private static readonly pb::MessageParser<Pong> _parser = new pb::MessageParser<Pong>(() => new Pong());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Pong> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Test.Grpc.TestReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pong() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pong(Pong other) : this() {
      epochSendTimestampNS_ = other.epochSendTimestampNS_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pong Clone() {
      return new Pong(this);
    }

    /// <summary>Field number for the "epochSendTimestampNS" field.</summary>
    public const int EpochSendTimestampNSFieldNumber = 1;
    private ulong epochSendTimestampNS_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong EpochSendTimestampNS {
      get { return epochSendTimestampNS_; }
      set {
        epochSendTimestampNS_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Pong);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Pong other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EpochSendTimestampNS != other.EpochSendTimestampNS) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EpochSendTimestampNS != 0UL) hash ^= EpochSendTimestampNS.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (EpochSendTimestampNS != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(EpochSendTimestampNS);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EpochSendTimestampNS != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(EpochSendTimestampNS);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Pong other) {
      if (other == null) {
        return;
      }
      if (other.EpochSendTimestampNS != 0UL) {
        EpochSendTimestampNS = other.EpochSendTimestampNS;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            EpochSendTimestampNS = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
