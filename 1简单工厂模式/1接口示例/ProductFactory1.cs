using 简单工厂模式.Interface;

namespace 简单工厂模式;

// 工厂类
public class ProductFactory1
{
    public IProduct CreateProduct(string type)
    {
        switch (type.ToLower())
        {
            case "a":
                return new ProductA();
            case "b":
                return new ProductB();
            default:
                throw new ArgumentException("Invalid product type.");
        }
    }
}