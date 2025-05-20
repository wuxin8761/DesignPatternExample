namespace _17.适配器模式;

public class PaymentAdapter : IPaymentProcessor
{
    private readonly ThirdPartyPaymentGateway _gateway;
    
    public PaymentAdapter(ThirdPartyPaymentGateway gateway)
    {
        _gateway = gateway;
    }
    
    public void ProcessPayment(decimal amount)
    {
        // 调用第三方支付方法，完成适配
        _gateway.MakeTransaction(amount);
    }
}