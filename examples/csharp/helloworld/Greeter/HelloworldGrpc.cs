// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: helloworld.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Helloworld {
  public static class Greeter
  {
    static readonly string __ServiceName = "helloworld.Greeter";

    static readonly Marshaller<global::Helloworld.HelloRequest> __Marshaller_HelloRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Helloworld.HelloRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Helloworld.HelloReply> __Marshaller_HelloReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Helloworld.HelloReply.Parser.ParseFrom);

    static readonly Method<global::Helloworld.HelloRequest, global::Helloworld.HelloReply> __Method_SayHello = new Method<global::Helloworld.HelloRequest, global::Helloworld.HelloReply>(
        MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_HelloRequest,
        __Marshaller_HelloReply);

    // service descriptor
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Helloworld.HelloworldReflection.Descriptor.Services[0]; }
    }

    // client interface
    public interface IGreeterClient
    {
      global::Helloworld.HelloReply SayHello(global::Helloworld.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::Helloworld.HelloReply SayHello(global::Helloworld.HelloRequest request, CallOptions options);
      AsyncUnaryCall<global::Helloworld.HelloReply> SayHelloAsync(global::Helloworld.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::Helloworld.HelloReply> SayHelloAsync(global::Helloworld.HelloRequest request, CallOptions options);
    }

    // server-side interface
    public interface IGreeter
    {
      Task<global::Helloworld.HelloReply> SayHello(global::Helloworld.HelloRequest request, ServerCallContext context);
    }

    // client stub
    public class GreeterClient : ClientBase, IGreeterClient
    {
      public GreeterClient(Channel channel) : base(channel)
      {
      }
      public global::Helloworld.HelloReply SayHello(global::Helloworld.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_SayHello, new CallOptions(headers, deadline, cancellationToken));
        return Calls.BlockingUnaryCall(call, request);
      }
      public global::Helloworld.HelloReply SayHello(global::Helloworld.HelloRequest request, CallOptions options)
      {
        var call = CreateCall(__Method_SayHello, options);
        return Calls.BlockingUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::Helloworld.HelloReply> SayHelloAsync(global::Helloworld.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_SayHello, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::Helloworld.HelloReply> SayHelloAsync(global::Helloworld.HelloRequest request, CallOptions options)
      {
        var call = CreateCall(__Method_SayHello, options);
        return Calls.AsyncUnaryCall(call, request);
      }
    }

    // creates service definition that can be registered with a server
    public static ServerServiceDefinition BindService(IGreeter serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder(__ServiceName)
          .AddMethod(__Method_SayHello, serviceImpl.SayHello).Build();
    }

    // creates a new client
    public static GreeterClient NewClient(Channel channel)
    {
      return new GreeterClient(channel);
    }

  }
}
#endregion