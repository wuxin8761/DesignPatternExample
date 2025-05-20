using _22.桥接模式.Abstract;
using _22.桥接模式.Interface;

namespace _22.桥接模式.IPhone;

public class HuaweiPhone : Phone
{
    public HuaweiPhone(IFunctionality functionality) : base(functionality)
    {
    }

    public override void UsePhone()
    {
        Console.Write("华为手机：");
        // 3. 调用功能接口的方法
        // 功能接口的方法中使用了具体的功能，这样就可以在子类中实现具体的功能
        Functionality.Use();
    }
}