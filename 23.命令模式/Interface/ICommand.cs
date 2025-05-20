namespace _23.命令模式;

// 1. 定义命令接口 ICommand
public interface ICommand
{
    void Execute();
    void Undo();
}