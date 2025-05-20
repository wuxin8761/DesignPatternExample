namespace _19.组合模式.Graphic;

// 3. 实现组合节点：图形组
public class GraphicGroup : IGraphic
{
    // 存储子图形
    private List<IGraphic> _graphics = new List<IGraphic>();

    public void Add(IGraphic graphic)
    {
        _graphics.Add(graphic);
    }

    public void Remove(IGraphic graphic)
    {
        _graphics.Remove(graphic);
    }

    public void Draw()
    {
        Console.WriteLine("开始绘制图形组：");
        foreach (var graphic in _graphics)
        {
            graphic.Draw();
        }
        Console.WriteLine("图形组绘制完成。\n");
    }
}