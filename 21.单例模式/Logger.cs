namespace _21.单例模式;

// 1. 实现标准线程安全的单例类
public sealed class Logger
{
    // 私有静态实例
    private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());

    // 公共属性访问实例
    public static Logger Instance => _instance.Value;

    // 构造函数私有，防止外部创建
    private Logger()
    {
        Console.WriteLine("Logger 实例已创建");
    }

    // 模拟写日志方法
    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}