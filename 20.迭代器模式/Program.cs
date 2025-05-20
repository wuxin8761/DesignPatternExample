// See https://aka.ms/new-console-template for more information

using _20.迭代器模式;

var inventory = new Inventory();
inventory.AddItem("剑");
inventory.AddItem("盾");
inventory.AddItem("药水");

IIterator<string> iterator = inventory.CreateIterator();

Console.WriteLine("遍历背包物品：");
while (iterator.MoveNext())
{
    Console.WriteLine(iterator.Current);
}