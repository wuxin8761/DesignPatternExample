using _2.策略模式.Interface;

namespace _2.策略模式;

// 具体策略类：普通会员折扣
public class NormalMemberStrategy : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        Console.WriteLine("普通会员，无折扣。");
        return price;
    }
}