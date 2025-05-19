// See https://aka.ms/new-console-template for more information

using 简单工厂模式;
using 简单工厂模式._2继承;
using 简单工厂模式.Interface;

// 1接口示例
var factory1 = new ProductFactory1();

IProduct productA = factory1.CreateProduct("a");
Console.WriteLine(productA.GetName()); // 输出: ProductA

IProduct productB = factory1.CreateProduct("b");
Console.WriteLine(productB.GetName()); // 输出: ProductB

// 2继承示例
var factory2 = new ProductFactory2();
Product productC = factory2.CreateProduct("c");
Console.WriteLine(productC.GetName());

Product productD = factory2.CreateProduct("d");
Console.WriteLine(productD.GetName()); // 输出: ProductB

