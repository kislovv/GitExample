namespace SuperCalculator;

public class FileLogger(string path) : ILogger
{
    public void Log(string message)
    {
        File.AppendAllText(path, $"{DateTime.Now}: {message}{Environment.NewLine}");
    }
}