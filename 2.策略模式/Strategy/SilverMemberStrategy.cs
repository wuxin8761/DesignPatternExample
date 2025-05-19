using _2.策略模式.Interface;

namespace _2.策略模式;

// 具体策略类：白银会员折扣
public class SilverMemberStrategy : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        Console.WriteLine("白银会员，10% 折扣。");
        return price * 0.9;
    }
}
