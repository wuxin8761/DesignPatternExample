namespace _16.状态模式.State;

// 待支付状态
public class PendingState : IOrderState
{
    public void Pay(Order order)
    {
        Console.WriteLine("订单已支付，状态从 [待支付] 变为 [已支付]");
        order.SetState(new PaidState());
    }

    public void Cancel(Order order)
    {
        Console.WriteLine("订单已取消，状态从 [待支付] 变为 [已取消]");
        order.SetState(new CanceledState());
    }
}