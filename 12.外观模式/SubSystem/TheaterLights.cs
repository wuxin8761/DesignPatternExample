namespace _12.外观模式;

// 1. 定义各个子系统类 - 灯光系统
public class TheaterLights
{
    public void Dim(int level)
    {
        Console.WriteLine($"灯光亮度设置为 {level}%");
    }

    public void On()
    {
        Console.WriteLine("灯光打开");
    }
}