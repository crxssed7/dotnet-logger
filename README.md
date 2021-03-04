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

## Installation
Download the latest release, and add a reference to the file in Visual Studio.

## Notes
- `ShowLogger();` does not work for console applications. With the current tests that I've done, the function only works on WinForms. I'm sure there is a way to hack it so it works though.
