namespace CustomerLogger;

public abstract class LoggerDecorator : ILogger
{
    protected ILogger _logger;
    public abstract void Log(string message);
}