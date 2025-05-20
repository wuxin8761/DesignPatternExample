namespace _23.命令模式.Command;

// 攻击命令
public class AttackCommand : ICommand
{
    private readonly Player _player;
    private string _lastAction;

    public AttackCommand(Player player)
    {
        _player = player;
    }

    public void Execute()
    {
        _lastAction = _player.CurrentAction;
        _player.Attack();
    }

    public void Undo()
    {
        _player.CurrentAction = _lastAction;
    }
}