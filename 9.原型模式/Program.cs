// See https://aka.ms/new-console-template for more information

// 创建原型对象

using _9.原型模式;

// 创建原型对象
var prototype = new Character { Name = "Hero", Level = 1 };

// 克隆出多个角色
var hero1 = (Character)prototype.Clone();
var hero2 = (Character)prototype.Clone();

// 修改其中一个角色不影响其他克隆对象
hero1.Level = 2;
hero2.Name = "Newbie";

Console.WriteLine(hero1); // 输出：Character { Name = Hero, Level = 2 }
Console.WriteLine(hero2); // 输出：Character { Name = Newbie, Level = 1 }