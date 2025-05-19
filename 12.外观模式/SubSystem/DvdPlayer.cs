namespace _12.外观模式;

// 1. 定义各个子系统类 - 播放器
public class DvdPlayer
{
    public void On()
    {
        Console.WriteLine("播放器启动");
    }

    public void Play(string movie)
    {
        Console.WriteLine($"{movie} 开始播放");
    }
}