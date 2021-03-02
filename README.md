# dotnet-logger
A wrapper to log events for your .NET application

**Log to the logger**
```csharp
DotNetLogger logger = new DotNetLogger();
logger.Log("This is a log");
```

**Show log messages in separate window**
```csharp
logger.ShowLogger();
```

**Generate a log file name**
```csharp
logger.GenerateLogFileName("projectName");
```

**Save logs to external file**
```csharp
logger.SaveLogs("/path/to/log/file.log");
```
