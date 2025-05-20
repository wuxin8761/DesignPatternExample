namespace _18.备忘录模式;

// 3. 定义 Caretaker（管理者）
public class History
{
    // Stack 是栈结构，后进先出
    // 创建一个栈来存储备忘录，每次保存时将备忘录压入栈中，每次撤销时将栈顶的备忘录弹出
    // readonly 表示只读，只能在构造函数中赋值，不能在其他地方赋值，只能使用 Push 和 Pop 方法来操作栈
    // 这样可以保证栈中的备忘录是有序的，最新的备忘录在栈顶，最早的备忘录在栈底
    private readonly Stack<TextMemento> _history = new Stack<TextMemento>();

    // Push 方法将备忘录压入栈中
    public void Push(TextMemento memento)
    {
        _history.Push(memento);
    }

    // Pop 方法将栈顶的备忘录弹出
    public TextMemento Pop()
    {
        return _history.Count > 0 ? _history.Pop() : null;
    }
}