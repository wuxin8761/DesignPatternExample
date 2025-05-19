namespace _6.装饰模式;

public class FileLoggerDecorator: LoggerDecorator
{
    // 构造函数中传递进来一个ILogger对象，并调用父类的构造函数，
    // 将ILogger对象传递给父类
    public FileLoggerDecorator(ILogger logger) : base(logger)
    {
    }
    
    public override void Log(string message)
    {
        // 调用父类的 Log 方法，即构造函数中传递过来的 logger的log方法
        base.Log(message);
        // 在Debug文件夹下生成
        File.AppendAllText("log.txt", message + Environment.NewLine);
    }
}