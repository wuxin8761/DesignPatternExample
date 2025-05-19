using _8.工厂方法模式.Interface;
using _8.工厂方法模式.Product;

namespace _8.工厂方法模式.Factory;

// 4. 具体工厂类
public class FactoryA : IFactory
{
    public IProduct CreateProduct()
    {
        return new ProductA();
    }
}