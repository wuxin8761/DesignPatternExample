namespace _16.状态模式.State;

// 已支付状态
public class PaidState : IOrderState
{
    public void Pay(Order order)
    {
        Console.WriteLine("订单已经支付过了！");
    }

    public void Cancel(Order order)
    {
        Console.WriteLine("无法取消已支付的订单！");
    }
}