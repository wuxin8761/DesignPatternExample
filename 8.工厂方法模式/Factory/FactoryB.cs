using _8.工厂方法模式.Interface;
using _8.工厂方法模式.Product;

namespace _8.工厂方法模式.Factory;

public class FactoryB : IFactory
{
    public IProduct CreateProduct()
    {
        return new ProductB();
    }
}