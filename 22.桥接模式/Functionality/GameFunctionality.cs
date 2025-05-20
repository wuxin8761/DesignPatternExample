using _22.桥接模式.Interface;

namespace _22.桥接模式.Functionality;


public class GameFunctionality : IFunctionality
{
    public void Use()
    {
        Console.WriteLine("正在玩游戏");
    }
}