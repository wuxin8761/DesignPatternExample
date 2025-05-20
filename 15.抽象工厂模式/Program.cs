// See https://aka.ms/new-console-template for more information

// 使用第一个工厂

using _15.抽象工厂模式;
using _15.抽象工厂模式.Factory;

var factory1 = new ConcreteFactory1();
var client1 = new Client(factory1);
client1.Run();  // 输出: Using ProductA1 and ProductB1

// 使用第二个工厂
var factory2 = new ConcreteFactory2();
var client2 = new Client(factory2);
client2.Run();  // 输出: Using ProductA2 and