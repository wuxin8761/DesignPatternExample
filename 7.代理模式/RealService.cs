namespace _7.代理模式;

// 2. 真实对象类
public class RealService : IService
{
    public void DoWork()
    {
        Console.WriteLine("真实服务正在工作...");
    }
}