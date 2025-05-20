using _22.桥接模式.Interface;

namespace _22.桥接模式.Abstract;

// 1. 定义抽象类
// 抽象类中包含了功能接口的引用，这样就可以在子类中使用功能接口的方法
// 抽象类中还包含了一个抽象方法，这个方法中使用了功能接口的方法，这样就可以在子类中实现具体的功能
public abstract class Phone
{
    protected IFunctionality Functionality;

    protected Phone(IFunctionality functionality)
    {
        Functionality = functionality;
    }

    // 2. 定义抽象方法 
    // 抽象方法中使用了功能接口的方法，这样就可以在子类中实现具体的功能
    public abstract void UsePhone();
}