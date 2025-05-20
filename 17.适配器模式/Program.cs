// See https://aka.ms/new-console-template for more information

using _17.适配器模式;

var thirdPartyGateway = new ThirdPartyPaymentGateway();
IPaymentProcessor processor = new PaymentAdapter(thirdPartyGateway);

processor.ProcessPayment(100.50m); // 100.50m 是 decimal 类型的字面量 m 表示这是一个 decimal 类型的值