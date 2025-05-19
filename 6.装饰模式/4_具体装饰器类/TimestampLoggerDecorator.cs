namespace _6.装饰模式;

// 4. 具体装饰器类
// 添加时间戳
public class TimestampLoggerDecorator : LoggerDecorator
{
    // 因为 LoggerDecorator 没有无参构造函数，
    // 所以在 TimestampLoggerDecorator 中必须手动定义构造函数并通过 base(logger) 调用父类构造函数，
    // 否则编译器将报错。
    // 基类有无参构造函数，则子类可以省略无参构造函数。
    // 父类有参构造函数，则子类必须定义有参构造函数。
    // 基类有多个构造函数，子类可选择调用哪一个
    
    // 构造函数中传递进来一个ILogger对象，并调用父类的构造函数，
    // 将ILogger对象传递给父类
    public TimestampLoggerDecorator(ILogger logger) : base(logger)
    {
    }
    
    // 重写 Log 方法
    public override void Log(string message)
    {
        string timestampMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
        
        // 调用父类的 Log 方法，即通过构造函数传递过来的 logger的log方法
        base.Log(timestampMessage);
    } 
}