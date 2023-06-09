using TemplateMethodPattern.Abstract;

namespace TemplateMethodPattern.Concrete;

public class UDPLogger : Logger
{
    protected override void LogMessage()
    {
        LogToUdpSink();
    }

    private void LogToUdpSink()
    {
        Console.WriteLine("Logging to UDP sink...");
    }
    
    // override hook operation
    protected override bool ConsoleToTerminal() // hook operation
    {
        return false;
    }
}