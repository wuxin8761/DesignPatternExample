namespace _26.享元模式;

// 🧠 x 和 y 是外部状态，每次调用 Draw() 时传入，不存储在共享对象中。
public class Tree
{
    private int x;
    private int y;
    private ITreeType type;

    public Tree(int x, int y, ITreeType type)
    {
        this.x = x;
        this.y = y;
        this.type = type;
    }

    public void Draw()
    {
        type.Display(x, y);
    }
}