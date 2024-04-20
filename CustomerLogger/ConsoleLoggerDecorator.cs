namespace CustomerLogger;

public class ConsoleLoggerDecorator : LoggerDecorator
{
    public ConsoleLoggerDecorator(ILogger logger)
    {
        _logger = logger;
    }
    public override void Log(string message)
    {
        _logger.Log(message);
        var consoleLog = new ConsoleLogger();
        consoleLog.Log(message);
    }
}