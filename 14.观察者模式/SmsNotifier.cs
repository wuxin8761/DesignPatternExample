namespace _14.观察者模式;

// 观察者：短信通知
public class SmsNotifier
{
    public void Update(object sender, WeatherEventArgs e)
    {
        Console.WriteLine($"短信通知：当前天气是 {e.Weather}");
    }
}