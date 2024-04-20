namespace CustomerLogger;

public class LoggerBuilder
{
    private ILogger _logger;

    public LoggerBuilder(ILogger logger)
    {
        _logger = logger;
    }

    public LoggerBuilder WithConsole()
    {
        _logger = new ConsoleLoggerDecorator(_logger);
        return this;
    }
    public LoggerBuilder WithFile(string path)
    {
        _logger = new FileLoggerDecorator(_logger, path);
        return this;
    }

    public ILogger Build()
    {
        return _logger;
    }
}