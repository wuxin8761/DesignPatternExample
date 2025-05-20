namespace _20.迭代器模式;

// 1. 定义迭代器接口 IIterator<T>
public interface IIterator<T>
{
    T Current { get; }
    bool MoveNext();
    void Reset();
}