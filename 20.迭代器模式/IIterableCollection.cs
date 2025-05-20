namespace _20.迭代器模式;

// 2. 定义集合接口 IIterableCollection<T>
public interface IIterableCollection<T>
{
    IIterator<T> CreateIterator();
}