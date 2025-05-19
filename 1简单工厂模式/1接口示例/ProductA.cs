using 简单工厂模式.Interface;

namespace 简单工厂模式;

// 具体产品 A
public class ProductA : IProduct
{
    public string GetName()
    {
        return "ProductA";
    }
}