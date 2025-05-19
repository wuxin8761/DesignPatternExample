namespace _9.原型模式;

public class Character : ICloneable
{
    public string Name { get; set; }
    public int Level { get; set; }

    // 拷贝
    public object Clone()
    {
        // 浅拷贝
        return MemberwiseClone();

        // 浅拷贝（Shallow Copy）
        // 复制对象本身，但不复制引用类型的字段

        // 深拷贝（Deep Copy）
        // 复制对象本身，并递归复制所有引用类型的字段

        // 实现深拷贝方式：
        // 1.手动赋值每个属性。
        // 2.使用序列化（如 JSON、BinaryFormatter）。
        // 3.使用第三方库（如 AutoMapper、FastDeepCloner）。

        // 示例代码：
        // using System.Text.Json;
        //
        // public static T DeepCopy<T>(T obj)
        // {
        //     var json = JsonSerializer.Serialize(obj);
        //     return JsonSerializer.Deserialize<T>(json);
        // }
        //
        // // 使用示例
        // var deepCopy = DeepCopy(original);
    }

    public override string ToString()
    {
        return $"Character {{ Name = {Name}, Level = {Level} }}";
    }
}