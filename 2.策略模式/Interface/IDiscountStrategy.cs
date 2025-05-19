namespace _2.策略模式.Interface;

// 定义策略接口
// 策略模式中，策略接口定义了所有策略的公共行为，包括执行折扣操作的方法。
// 在本示例中，策略接口只有一个方法，用于执行折扣操作，并返回折扣后的价格。
// DiscountStrategy 折扣策略
public interface IDiscountStrategy
{
    // 申请折扣
    double ApplyDiscount(double price);
}
