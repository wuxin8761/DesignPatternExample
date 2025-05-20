namespace _18.备忘录模式;

// 定义 Memento 类（备忘录）
// 存储 Originator（发起人） 的状态，通常只有 Originator （发起人） 可以访问它的内容。
public class TextMemento
{
    public string Content { get; }

    public TextMemento(string content)
    {
        Content = content;
    }
}