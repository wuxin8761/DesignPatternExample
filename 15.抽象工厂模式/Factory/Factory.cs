using _15.抽象工厂模式.Interface;
using _15.抽象工厂模式.Product;

namespace _15.抽象工厂模式.Factory;

// 具体工厂1：生成产品A1和B1
public class ConcreteFactory1 : IAbstractFactory
{
    public IProductA CreateProductA() => new ProductA1();
    public IProductB CreateProductB() => new ProductB1();
}

// 具体工厂2：生成产品A2和B2
public class ConcreteFactory2 : IAbstractFactory
{
    public IProductA CreateProductA() => new ProductA2();
    public IProductB CreateProductB() => new ProductB2();
}