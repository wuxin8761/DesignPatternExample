namespace _26.享元模式;

// 3. 创建 FlyweightFactory 来管理对象池
// 使用字典缓存已创建的 TreeType 对象，实现复用。
public class TreeFactory
{
    private Dictionary<string, ITreeType> _treeTypes = new Dictionary<string, ITreeType>();

    public ITreeType GetTreeType(string name, string color)
    {
        string key = $"{name}_{color}";

        if (!_treeTypes.ContainsKey(key))
        {
            _treeTypes[key] = new TreeType(name, color);
        }

        return _treeTypes[key];
    }
}