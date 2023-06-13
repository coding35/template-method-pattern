using System.Diagnostics.CodeAnalysis;

namespace TemplateMethodPattern.Abstract;

public abstract class Logger
{
    private DateTime _logTime = DateTime.Now;
    private string _hostInfo = string.Empty;
    protected bool _enableConsoleToTerminal;
    protected string Message { get; private set; } = null!;
    public void Log(LoggerMessage log)
    {
        _logTime = GetLogTime();    // Logger will handle this
        _hostInfo = GetHostInfo();  // Logger will handle this
        log.SetLogTime(_logTime);   // delegate to LoggerMessage
        log.SetHostInfo(_hostInfo); // delegate to LoggerMessage
        FormatMessage(log);         // Logger will handle this
        LogMessage();               // delegate to subclass
        if (ConsoleToTerminal())    // hook operation to add additional step to algorithm
        {
            Console.WriteLine(Message);
        }
    }

    protected abstract void LogMessage(); // primitive operation
    protected virtual bool ConsoleToTerminal() // hook operation
    {
        return true;
    }
    
    private DateTime GetLogTime() // concrete operation
    {
        return DateTime.Now;
    }

    private string GetHostInfo() // concrete operation
    {
        return Environment.MachineName;
    }

    private void FormatMessage(LoggerMessage msg) // concrete operation
    {
        Message = $"{msg.LogTime} {msg.HostInfo} {msg.MethodName} {msg.Message} {msg.Exception} {msg.Level}";
    }
    
    public void ToggleConsoleToTerminal(bool enabled) // hook operation
    {
        _enableConsoleToTerminal = enabled;
    }
}