using _2.策略模式.Interface;

namespace _2.策略模式;

// 具体策略类：黄金会员折扣
public class GoldMemberStrategy : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        Console.WriteLine("黄金会员，20% 折扣。");
        return price * 0.8;
    }
}