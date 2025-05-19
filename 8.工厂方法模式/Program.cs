// See https://aka.ms/new-console-template for more information

using _8.工厂方法模式.Factory;
using _8.工厂方法模式.Interface;

IFactory factory = new FactoryA();
var product = factory.CreateProduct();
product.Use(); // 输出：使用产品 A

factory = new FactoryB();
product = factory.CreateProduct();
product.Use(); // 输出：使用产品 B