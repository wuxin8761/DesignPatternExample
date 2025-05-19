namespace _6.装饰模式;

// 3. 抽象装饰器类.
// abstract 抽象类

public abstract class LoggerDecorator: ILogger
{
    // 抽象装饰器类中保存被装饰的对象
    protected ILogger decoratedLogger;

    // 抽象装饰器类中构造函数中保存被装饰的对象
    public LoggerDecorator(ILogger logger)
    {
        decoratedLogger = logger;
    }

    // 抽象装饰器类中实现日志记录方法
    // virtual， 虚方法， 子类可以重写
    public virtual void Log(string message)
    {
        decoratedLogger.Log(message);
    }
}