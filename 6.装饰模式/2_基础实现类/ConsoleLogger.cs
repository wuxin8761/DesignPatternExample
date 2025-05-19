namespace _6.装饰模式;

// 2. 基础实现类
public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[日志] {message}");
    }
}
