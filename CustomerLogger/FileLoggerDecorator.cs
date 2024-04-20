namespace CustomerLogger;

public class FileLoggerDecorator : LoggerDecorator
{
    private readonly string _path;
    public FileLoggerDecorator(ILogger logger, string path)
    {
        _path = path;
        _logger = logger;
    }
    public override void Log(string message)
    {
        _logger.Log(message);
        var fileLog = new FileLogger(_path);
        fileLog.Log(message);
    }
}