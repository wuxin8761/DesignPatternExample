namespace _14.观察者模式;

// 1. 定义事件参数类
// 自定义事件参数，携带天气信息
public class WeatherEventArgs : EventArgs
{
    public string Weather { get; }

    public WeatherEventArgs(string weather)
    {
        Weather = weather;
    }
}