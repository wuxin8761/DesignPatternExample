namespace _18.备忘录模式;

// 2. 定义 Originator（发起人）
// 创建一个备忘录并存储其当前状态；也可以使用备忘录恢复状态。
public class TextEditor
{
    private string _content = "";

    // 设置内容
    public void Type(string text)
    {
        _content += text;
    }

    // 获取当前内容
    public string GetContent()
    {
        return _content;
    }

    // 创建备忘录
    public TextMemento Save()
    {
        return new TextMemento(_content);
    }

    // 恢复内容
    public void Restore(TextMemento memento)
    {
        _content = memento.Content;
    }
}