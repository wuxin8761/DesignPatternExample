namespace _16.状态模式;

// 订单状态接口
public interface IOrderState
{
    // 支付
    void Pay(Order order);
    // 取消
    void Cancel(Order order);
}