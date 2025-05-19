// See https://aka.ms/new-console-template for more information

// 创建被观察者

using _14.观察者模式;

var weatherService = new WeatherService();

// 创建观察者
var smsNotifier = new SmsNotifier();
var emailNotifier = new EmailNotifier();

// 注册观察者（订阅事件）
weatherService.WeatherChanged += smsNotifier.Update;
weatherService.WeatherChanged += emailNotifier.Update;

// 模拟天气变化
weatherService.SetWeather("晴天");