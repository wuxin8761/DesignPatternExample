using _15.抽象工厂模式.Interface;

namespace _15.抽象工厂模式;

// 5. 使用抽象工厂
public class Client
{
    private readonly IProductA _productA;
    private readonly IProductB _productB;

    public Client(IAbstractFactory factory)
    {
        _productA = factory.CreateProductA();
        _productB = factory.CreateProductB();
    }

    public void Run()
    {
        Console.WriteLine($"Using {_productA.Operation()} and {_productB.Operation()}");
    }
}