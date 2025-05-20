namespace _16.状态模式.State;

// 已取消状态
public class CanceledState : IOrderState
{
    public void Pay(Order order)
    {
        Console.WriteLine("已取消的订单不能再次支付！");
    }

    public void Cancel(Order order)
    {
        Console.WriteLine("订单已经是已取消状态！");
    }
}