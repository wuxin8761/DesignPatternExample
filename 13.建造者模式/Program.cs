// See https://aka.ms/new-console-template for more information

// 创建建造者

using _13.建造者模式;

// 创建建造者
IComputerBuilder builder = new StandardComputerBuilder();

// 创建指挥者
ComputerDirector director = new ComputerDirector();

// 构建游戏电脑
director.BuildGamingComputer(builder);
Computer gamingComputer = builder.Build();
Console.WriteLine("Gaming Computer:");
Console.WriteLine(gamingComputer);

// 构建办公电脑
director.BuildOfficeComputer(builder);
Computer officeComputer = builder.Build();
Console.WriteLine("\nOffice Computer:");
Console.WriteLine(officeComputer);