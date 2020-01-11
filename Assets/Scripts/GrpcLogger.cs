using System;
using UnityEngine;
using Grpc.Core;

class GrpcLogger : Grpc.Core.Logging.ILogger
{
    void Grpc.Core.Logging.ILogger.Debug(string message)
    {
        Debug.Log("DEBUG: " + message);
    }

    void Grpc.Core.Logging.ILogger.Debug(string format, params object[] formatArgs)
    {
        Debug.LogFormat("DEBUG: " + format, formatArgs);
    }

    void Grpc.Core.Logging.ILogger.Error(string message)
    {
        Debug.LogError("ERROR: " + message);
    }

    void Grpc.Core.Logging.ILogger.Error(string format, params object[] formatArgs)
    {
        Debug.LogErrorFormat("ERROR: " + format, formatArgs);
    }

    void Grpc.Core.Logging.ILogger.Error(Exception exception, string message)
    {
        Debug.LogException(exception);
        Debug.LogError("ERROR: " + message);
    }

    Grpc.Core.Logging.ILogger Grpc.Core.Logging.ILogger.ForType<T>()
    {
        return new GrpcLogger();
    }

    void Grpc.Core.Logging.ILogger.Info(string message)
    {
        Debug.Log("INFO: " + message);
    }

    void Grpc.Core.Logging.ILogger.Info(string format, params object[] formatArgs)
    {
        Debug.LogFormat("INFO: " + format, formatArgs);
    }

    void Grpc.Core.Logging.ILogger.Warning(string message)
    {
        Debug.LogWarningFormat("WARN: " + message);
    }

    void Grpc.Core.Logging.ILogger.Warning(string format, params object[] formatArgs)
    {
        Debug.LogWarningFormat("WARN: " + format, formatArgs);
    }

    void Grpc.Core.Logging.ILogger.Warning(Exception exception, string message)
    {
        Debug.LogException(exception);
        Debug.LogWarning("WARN: " + message);
    }
}