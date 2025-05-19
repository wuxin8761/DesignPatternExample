namespace _7.代理模式;

// 3. 代理类
public class ServiceProxy : IService
{
    // 引用真实服务
    private RealService _realService;

    // 实现接口方法
    public void DoWork()
    {
        // 前置逻辑：权限检查 + 懒加载
        if (CheckAccess())
        {
            _realService ??= new RealService(); // 懒加载
            
            // ??=是什么意思？
            // ??= 是 C# 中的 空合并赋值运算符（Null-coalescing assignment operator），
            // 其作用是：如果左侧的操作数不为 null，则不做任何操作；
            // 如果左侧的操作数为 null，则将右侧的值赋给左侧。
            
            // 等价于
            // if (_realService == null)
            // {
            //     _realService = new RealService();
            // }
            
            Console.WriteLine("[代理] 开始调用真实服务");
            _realService.DoWork();
            Console.WriteLine("[代理] 调用完成，记录日志");
        }
    }

    private bool CheckAccess()
    {
        // 模拟权限判断
        Console.WriteLine("[代理] 正在检查权限...");
        return true; // 假设已授权
    }
}