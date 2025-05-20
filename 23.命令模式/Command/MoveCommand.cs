using System.Numerics;

namespace _23.命令模式.Command;

// 移动命令
public class MoveCommand : ICommand
{
    private readonly Player _player;
    private Vector2 _lastPosition;

    public MoveCommand(Player player)
    {
        _player = player;
    }

    public void Execute()
    {
        _lastPosition = _player.Position;
        _player.Move(10, 0);
    }

    public void Undo()
    {
        _player.Position = _lastPosition;
    }
}