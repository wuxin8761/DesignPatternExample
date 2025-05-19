namespace _14.观察者模式;

// 2. 被观察者类（Subject）
// 被观察者：天气服务
public class WeatherService
{
    // 定义事件，使用泛型 EventHandler
    
    // 泛型版本，支持自定义事件数据
    public event EventHandler<WeatherEventArgs> WeatherChanged;
    
    // 模拟天气变化并触发事件
    public void SetWeather(string weather)
    {
        Console.WriteLine("天气服务：天气已更新为 " + weather);
        
        OnWeatherChanged(new WeatherEventArgs(weather));
    }

    // 
    protected virtual void OnWeatherChanged(WeatherEventArgs e)
    {
        // 安全地触发事件，通知所有观察者
        WeatherChanged?.Invoke(this, e);
    }
}