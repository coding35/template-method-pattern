using System.Diagnostics;

namespace TemplateMethodPattern.Abstract;

public class LoggerMessage 
{
    public LoggerMessage(string methodName, string message, Exception? exception, TraceLevel level)
    {
        MethodName = methodName;
        Message = message;
        Exception = exception;
        Level = level;
    }

    public string MethodName { get; set; }
    public string Message { get; set; }
    public Exception? Exception { get; set; }
    public TraceLevel Level { get; set; }  
    public string HostInfo { get; set; } = null!;
    public DateTime LogTime { get; set; }
    
    public void SetLogTime(DateTime logTime)
    {
        LogTime = logTime;
    }
    
    public void SetHostInfo(string hostInfo)
    {
        HostInfo = hostInfo;
    }
}