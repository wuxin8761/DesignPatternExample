namespace _25.中介者模式;

// 用户
public class User
{
    public string Name { get; private set; }
    private IChatMediator _mediator;

    public User(string name, IChatMediator mediator)
    {
        Name = name;
        _mediator = mediator;
        _mediator.RegisterUser(this);
    }

    public void Send(string message)
    {
        _mediator.SendMessage(message, this);
    }

    public void Receive(string message)
    {
        Console.WriteLine(message);
    }
}