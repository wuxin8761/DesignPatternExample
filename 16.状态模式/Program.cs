// See https://aka.ms/new-console-template for more information

using _16.状态模式;
using _16.状态模式.State;

var order = new Order();

order.Pay();  // 输出: 订单已支付，状态从 [待支付] 变为 [已支付]
order.Pay();  // 输出: 订单已经支付过了！

order.Cancel(); // 输出: 无法取消已支付的订单！

// 手动设置为取消状态试试
order.SetState(new CanceledState());
order.Pay(); // 输出: 已取消的订单不能再次支付！