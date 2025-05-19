namespace _12.外观模式;

// 创建外观类
public class HomeTheaterFacade
{
    private readonly DvdPlayer _dvdPlayer;
    private readonly TheaterLights _lights;
    private readonly Projector _projector;
    private readonly SoundSystem _sound;

    public HomeTheaterFacade(TheaterLights lights, Projector projector, SoundSystem sound, DvdPlayer dvdPlayer)
    {
        _lights = lights;
        _projector = projector;
        _sound = sound;
        _dvdPlayer = dvdPlayer;
    }

    // 客户端只需调用一个方法即可完成观影准备
    public void WatchMovie(string movieName)
    {
        _lights.Dim(10);
        _projector.On();
        _projector.SetInput("HDMI");
        _sound.On();
        _sound.SetVolume(80);
        _dvdPlayer.On();
        _dvdPlayer.Play(movieName);
    }

    // 结束观影
    public void EndMovie()
    {
        _dvdPlayer.On();
        _sound.On();
        _projector.On();
        _lights.On();
        Console.WriteLine("电影结束，设备已恢复默认状态");
    }
}