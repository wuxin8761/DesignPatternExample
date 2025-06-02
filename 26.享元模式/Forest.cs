namespace _26.享元模式;

public class Forest
{
    private List<Tree> trees = new List<Tree>();
    private TreeFactory factory = new TreeFactory();

    public void PlantTree(int x, int y, string name, string color)
    {
        var type = factory.GetTreeType(name, color);
        trees.Add(new Tree(x, y, type));
    }

    public void Draw()
    {
        foreach (var tree in trees)
        {
            tree.Draw();
        }
    }
}