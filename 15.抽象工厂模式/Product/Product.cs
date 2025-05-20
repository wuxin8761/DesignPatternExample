using _15.抽象工厂模式.Interface;

namespace _15.抽象工厂模式.Product;

// 具体产品A1
public class ProductA1 : IProductA
{
    public string Operation() => "ProductA1";
}

// 具体产品A2
public class ProductA2 : IProductA
{
    public string Operation() => "ProductA2";
}

// 具体产品B1
public class ProductB1 : IProductB
{
    public string Operation() => "ProductB1";
}

// 具体产品B2
public class ProductB2 : IProductB
{
    public string Operation() => "ProductB2";
}