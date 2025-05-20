namespace _20.迭代器模式;

using System.Collections.Generic;

public class Inventory : IIterableCollection<string>
{
    private readonly List<string> _items = new List<string>();

    public void AddItem(string item)
    {
        _items.Add(item);
    }

    public IIterator<string> CreateIterator()
    {
        return new InventoryIterator(this);
    }

    // 提供给迭代器访问的内部方法
    internal int Count => _items.Count;
    internal string GetItem(int index) => _items[index];
}