namespace _15.抽象工厂模式.Interface;

// 抽象工厂接口
public interface IAbstractFactory
{
    IProductA CreateProductA();
    IProductB CreateProductB();
}