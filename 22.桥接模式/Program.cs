// See https://aka.ms/new-console-template for more information

// 华为 + 打电话

using _22.桥接模式.Functionality;
using _22.桥接模式.IPhone;

// 华为 + 打电话
var phone1 = new HuaweiPhone(new CallFunctionality());
// 调用传入 实现了功能接口的功能类 
// 这样就可以在子类中实现具体的功能
phone1.UsePhone();

// 苹果 + 播放音乐
var phone2 = new IPhone(new MusicFunctionality());
phone2.UsePhone();

// 华为 + 游戏
var phone3 = new HuaweiPhone(new GameFunctionality());
phone3.UsePhone();