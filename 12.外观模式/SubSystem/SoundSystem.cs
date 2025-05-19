namespace _12.外观模式;

// 1. 定义各个子系统类 - 音响系统
public class SoundSystem
{
    public void On()
    {
        Console.WriteLine("音响系统启动");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"音量设置为 {volume}");
    }
}