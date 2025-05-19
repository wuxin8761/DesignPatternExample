// See https://aka.ms/new-console-template for more information

using _2.策略模式;

var cart = new ShoppingCart();

// 普通会员
// 设置默认的普通会员策略
cart.SetDiscountStrategy(new NormalMemberStrategy());
Console.WriteLine($"最终价格: {cart.Checkout(100)}\n");

// 白银会员
// 设置白银会员策略
cart.SetDiscountStrategy(new SilverMemberStrategy());
Console.WriteLine($"最终价格: {cart.Checkout(100)}\n");

// 黄金会员
// 设置黄金会员策略
cart.SetDiscountStrategy(new GoldMemberStrategy());
Console.WriteLine($"最终价格: {cart.Checkout(100)}");

