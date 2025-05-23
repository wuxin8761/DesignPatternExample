namespace _25.中介者模式;

// 具体中介者：聊天室
public class ChatRoom : IChatMediator
{
    private List<User> _users = new List<User>();

    public void RegisterUser(User user)
    {
        _users.Add(user);
    }

    public void SendMessage(string message, User sender)
    {
        foreach (var user in _users.Where(u => u != sender))
        {
            user.Receive($"[{sender.Name}]: {message}");
        }
    }
}