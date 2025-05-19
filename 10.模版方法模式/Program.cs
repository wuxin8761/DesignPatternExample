// See https://aka.ms/new-console-template for more information

using _10.模版方法模式;

// 3. 客户端调用
CharacterLoader loader;

Console.WriteLine("加载战士角色:");
loader = new WarriorLoader();
loader.LoadCharacter();

Console.WriteLine("\n加载法师角色:");
loader = new MageLoader();
loader.LoadCharacter();