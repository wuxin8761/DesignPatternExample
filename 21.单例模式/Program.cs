// See https://aka.ms/new-console-template for more information

// 获取单例实例

using _21.单例模式;

var logger1 = Logger.Instance;
logger1.Log("第一次日志");

// 再次获取，仍然是同一个实例
var logger2 = Logger.Instance;
logger2.Log("第二次日志");

// 判断是否是同一个实例
Console.WriteLine($"logger1 == logger2: {logger1 == logger2}"); // 输出 True