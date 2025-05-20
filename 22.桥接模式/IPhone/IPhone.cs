using _22.桥接模式.Abstract;
using _22.桥接模式.Interface;

namespace _22.桥接模式.IPhone;

public class IPhone : Phone
{
    public IPhone(IFunctionality functionality) : base(functionality)
    {
    }

    public override void UsePhone()
    {
        Console.Write("苹果手机：");
        Functionality.Use();
    }
}