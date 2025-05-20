namespace _20.迭代器模式;

// 4. 实现具体的迭代器类：InventoryIterator
public class InventoryIterator : IIterator<string>
{
    private readonly Inventory _inventory;
    private int _currentIndex = 0;

    public InventoryIterator(Inventory inventory)
    {
        _inventory = inventory;
    }

    public string Current => _inventory.GetItem(_currentIndex);

    public bool MoveNext()
    {
        if (_currentIndex < _inventory.Count)
        {
            _currentIndex++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _currentIndex = 0;
    }
}