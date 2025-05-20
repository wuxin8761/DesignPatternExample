using _16.状态模式.State;

namespace _16.状态模式;

public class Order
{
    private IOrderState _state;

    public Order()
    {
        _state = new PendingState(); // 初始状态为待支付
    }
    
    public void SetState(IOrderState state)
    {
        _state = state;
    }
    
    public void Pay()
    {
        _state.Pay(this);
    }
    
    public void Cancel()
    {
        _state.Cancel(this);
    }
}