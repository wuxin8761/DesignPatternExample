// See https://aka.ms/new-console-template for more information

// 创建单独的图形

using _19.组合模式.Graphic;

var circle = new Circle();
var rectangle = new Rectangle();

// 创建一个图形组
var group = new GraphicGroup();
group.Add(circle);
group.Add(rectangle);

// 统一调用Draw方法
Console.WriteLine("绘制单个图形：");
circle.Draw();

Console.WriteLine("\n绘制图形组：");
group.Draw();

// 可以嵌套使用
var nestedGroup = new GraphicGroup();
nestedGroup.Add(group);
nestedGroup.Add(new Circle());

Console.WriteLine("绘制嵌套图形组：");
nestedGroup.Draw();
