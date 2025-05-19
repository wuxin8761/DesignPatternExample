using _8.工厂方法模式.Interface;

namespace _8.工厂方法模式.Product;

// 2. 具体产品类
public class ProductA : IProduct
{
    public void Use()
    {
        Console.WriteLine("使用产品 A");
    }
}