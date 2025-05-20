using System.Numerics;

namespace _23.命令模式;

// 3. 创建角色类 Player
public class Player
{
    public Vector2 Position { get; set; }
    public string CurrentAction { get; set; }

    public void Move(float x, float y)
    {
        Position = new Vector2(Position.X + x, Position.Y + y);
        Console.WriteLine($"角色移动到：{Position}");
    }

    public void Attack()
    {
        CurrentAction = "攻击";
        Console.WriteLine("角色发动攻击");
    }
}