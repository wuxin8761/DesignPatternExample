using 简单工厂模式.Interface;

namespace 简单工厂模式;

// 具体产品 B
public class ProductB : IProduct
{
    public string GetName()
    {
        return "ProductB";
    }
}