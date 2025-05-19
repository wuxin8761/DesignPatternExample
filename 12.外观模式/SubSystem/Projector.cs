namespace _12.外观模式;

// 1. 定义各个子系统类 - 投影仪
public class Projector
{
    public void On()
    {
        Console.WriteLine("投影仪打开");
    }

    public void SetInput(string input)
    {
        Console.WriteLine($"投影仪输入源设置为 {input}");
    }
}