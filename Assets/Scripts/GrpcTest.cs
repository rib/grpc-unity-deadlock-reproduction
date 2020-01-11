using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.Networking;

using Grpc.Core;

using Test.Grpc;

public class GrpcTest : MonoBehaviour
{
    void Start()
    {
        Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);

        Environment.SetEnvironmentVariable("GRPC_VERBOSITY", "INFO");
        Environment.SetEnvironmentVariable("GRPC_TRACE", "api,channel,connectivity_state,executor");
        Debug.Log("GRPC_VERBOSITY = " + Environment.GetEnvironmentVariable("GRPC_VERBOSITY"));
        Debug.Log("GRPC_TRACE = " + Environment.GetEnvironmentVariable("GRPC_TRACE"));

        Debug.Log("Setting Grpc Logger");
        var logger = new Grpc.Core.Logging.LogLevelFilterLogger(new GrpcLogger(),
                                                                Grpc.Core.Logging.LogLevel.Info);
        Grpc.Core.GrpcEnvironment.SetLogger(logger);
    }

    void Update()
    {

    }

    public string testAddress = "127.0.0.1";
    public int testPort = 50051;
    public bool useTls = false;
    public bool sendAuthToken = false;
    public bool readStreamBeforeDispose = false;

    private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0);
    private ulong GetEpochTimestampNS()
    {
        var timeSpan = (DateTime.UtcNow - UnixEpoch);
        ulong seconds = (ulong)timeSpan.TotalSeconds;
        uint nanos = (uint)((timeSpan.TotalSeconds - seconds) * 1e9);
        ulong timestampNS = seconds * (ulong)1000000000 + nanos;
        return timestampNS;
    }

    public async void RunGrpcTest()
    {
        var cancellationTokenSource = new CancellationTokenSource();

        var interceptor = new AsyncAuthInterceptor(async (context, metadata) =>
        {
            // dummy token, with a "username" claim
            metadata.Add("authorization", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VybmFtZSI6InRlc3QifQ.hNQI_r8BATy1LyXPr6Zuo9X_V0kSED8ngcqQ6G-WV5w");
        });

        string address = "" + testAddress + ":" + testPort;
        ChannelCredentials credentials = null;

        if (useTls)
        {
            var certUri = Path.Combine(Application.streamingAssetsPath, "ca.crt");
            var req = UnityWebRequest.Get(certUri);
            await req.SendWebRequest();
            var cacert = req.downloadHandler.text;

            if (sendAuthToken)
            {
                credentials = ChannelCredentials.Create(new SslCredentials(cacert),
                    CallCredentials.FromInterceptor(interceptor));
            }
            else
            {
                credentials = new SslCredentials(cacert);
            }
        }
        else
        {
            credentials = ChannelCredentials.Insecure;
        }

        var channel = new Channel(address, credentials);

        var client = new Test.Grpc.Test.TestClient(channel);

        try {
            var sentTs = GetEpochTimestampNS();
            var pong = await client.SendPingAsync(new Test.Grpc.Ping { EpochSendTimestampNS = sentTs },
                                                    deadline: DateTime.UtcNow.AddSeconds(10),
                                                    cancellationToken: cancellationTokenSource.Token);
            var receivedTs = pong.EpochSendTimestampNS;
            var delta = receivedTs - sentTs;
            Debug.Log("Ping sent to Frontend (timestamp = " + sentTs + "),  Pong Received (timestamp = " + receivedTs + "), Round Trip = " + delta);

            Debug.Log("Opening test stream...");
            using (var streamCall = client.OpenTestStream(new Test.Grpc.Empty {},
                                                          new CallOptions(deadline: DateTime.UtcNow.AddSeconds(30),
                                                                          cancellationToken: cancellationTokenSource.Token)))
            {
                if (readStreamBeforeDispose)
                {
                    if (await streamCall.ResponseStream.MoveNext()) {
                        Debug.Log("Received Empty{} item on test stream");
                    } else {
                        Debug.Log("Nothing read from test stream");
                    }
                }
                else
                {
                    Debug.Log("Immediately disposing test stream");
                }
            }
        }
        finally
        {
            Debug.Log("Shutting down channel...");
            await channel.ShutdownAsync();
        }

        Debug.Log("Done");
    }
}
