namespace _25.中介者模式;

public interface IChatMediator
{
    void SendMessage(string message, User sender);
    void RegisterUser(User user);
}