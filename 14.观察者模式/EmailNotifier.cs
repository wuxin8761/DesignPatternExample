namespace _14.观察者模式;

// 观察者：邮件通知
public class EmailNotifier
{
    public void Update(object sender, WeatherEventArgs e)
    {
        Console.WriteLine($"邮件通知：天气更新为 {e.Weather}");
    }
}