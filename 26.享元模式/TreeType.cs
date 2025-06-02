namespace _26.享元模式;

public class TreeType : ITreeType
{
    private string name;
    private string color;

    public TreeType(string name, string color)
    {
        this.name = name;
        this.color = color;
    }

    public void Display(int x, int y)
    {
        Console.WriteLine($"Drawing {name} tree at ({x}, {y}) with color {color}");
    }
}