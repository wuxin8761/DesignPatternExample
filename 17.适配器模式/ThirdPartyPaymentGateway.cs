namespace _17.适配器模式;

// 第三方支付网关 ThirdPartyPaymentGateway
public class ThirdPartyPaymentGateway
{
    // 第三方支付方法 MakeTransaction
    public void MakeTransaction(decimal value)
    {
        Console.WriteLine($"第三方支付：金额 {value:C}"); // value:C 是格式化输出，C 表示货币格式
    }
}