namespace _23.命令模式;

public class GameInvoker
{
    private ICommand _command;
    private readonly Stack<ICommand> _history = new Stack<ICommand>();

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        _command.Execute();
        _history.Push(_command);
    }

    public void UndoLastCommand()
    {
        if (_history.Count > 0)
        {
            var lastCommand = _history.Pop();
            lastCommand.Undo();
        }
    }
}