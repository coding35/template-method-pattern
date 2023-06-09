using TemplateMethodPattern.Abstract;

namespace TemplateMethodPattern.Concrete;

public class FileLogger : Logger
{
    protected override void LogMessage()
    {
        LogToFile();
    }
    
    private void LogToFile()
    {
        File.AppendAllText("log.txt", Message + Environment.NewLine);
        Console.WriteLine("Logging to file...");
    }
}