// See https://aka.ms/new-console-template for more information

using _23.命令模式;
using _23.命令模式.Command;

// 发送者不需要知道具体接收者是谁
// 命令接受者
var player = new Player();
// 命令发送者
var invoker = new GameInvoker();

// 设置并执行移动命令
ICommand moveCommand = new MoveCommand(player);
invoker.SetCommand(moveCommand);
invoker.ExecuteCommand(); // 输出：角色移动到：{X:10,Y:0}

// 设置并执行攻击命令
ICommand attackCommand = new AttackCommand(player);
invoker.SetCommand(attackCommand);
invoker.ExecuteCommand(); // 输出：角色发动攻击

// 撤销上一次操作（攻击）
invoker.UndoLastCommand(); // 恢复攻击前状态

// 再次撤销（移动）
invoker.UndoLastCommand(); // 恢复移动前位置