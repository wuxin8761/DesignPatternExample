using _2.策略模式.Interface;

namespace _2.策略模式;

// 上下文类
// 什么是上下文类？
// 在**策略模式（Strategy Pattern）**中，上下文类（Context Class） 是一个用于封装策略执行环境的类。它持有策略接口的一个引用，并通过该接口与具体的策略类进行交互。
// 上下文类的作用：
// 持有策略接口的引用：通过组合的方式引用策略接口 IDiscountStrategy，而不是直接依赖具体策略类。
// 委托策略逻辑：将具体的算法或行为委托给策略接口实现类来完成。
// 动态切换策略：可以在运行时根据需要更改策略对象，从而改变行为。

// 购物车
public class ShoppingCart
{
    // 折扣策略
    private IDiscountStrategy _discountStrategy;
 
    //  设置折扣策略
    public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    //  计算价格
    public double Checkout(double totalPrice)
    {
        if (_discountStrategy == null)
            throw new InvalidOperationException("未设置折扣策略。");

        return _discountStrategy.ApplyDiscount(totalPrice);
    }
}