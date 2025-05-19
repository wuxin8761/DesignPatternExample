在 C# 中，**抽象方法（abstract method）** 和 **虚方法（virtual method）** 都用于实现多态，但它们的使用场景和行为有明显区别。下面是它们的核心差异：

---

## 🔍 抽象方法 vs 虚方法

| 特性 | 抽象方法 (`abstract`) | 虚方法 (`virtual`) |
|------|------------------------|---------------------|
| 所在类 | 必须在 `abstract class` 中定义 | 可以在普通类或抽象类中定义 |
| 是否有实现 | ❌ 没有实现（无方法体） | ✅ 有默认实现 |
| 是否必须重写 | ✅ 子类必须使用 `override` 实现 | ❌ 子类可以选择是否重写 |
| 是否可以密封 | ❌ 抽象方法不能被 `sealed` | ✅ 可以用 `sealed override` 密封重写 |
| 多态支持 | ✅ 支持运行时多态 | ✅ 支持运行时多态 |

---

## 📌 示例对比

### ✅ 抽象方法示例：
```csharp
public abstract class Animal
{
    // 抽象方法：没有实现
    public abstract void MakeSound();
}

public class Dog : Animal
{
    // 必须重写抽象方法
    public override void MakeSound()
    {
        Console.WriteLine("汪汪！");
    }
}
```


### ✅ 虚方法示例：
```csharp
public class Animal
{
    // 虚方法：有默认实现
    public virtual void MakeSound()
    {
        Console.WriteLine("动物叫...");
    }
}

public class Cat : Animal
{
    // 可选重写
    public override void MakeSound()
    {
        Console.WriteLine("喵~");
    }
}
```


---

## 🧠 使用建议

| 场景 | 推荐方式 |
|------|----------|
| 父类无法提供合理默认实现，子类必须自定义逻辑 | ✅ 使用 `abstract` 方法 |
| 父类有默认行为，子类可选择是否修改行为 | ✅ 使用 `virtual` 方法 |
| 构建框架基类、强制子类实现特定功能 | ✅ 使用 `abstract` 类 + `abstract` 方法 |
| 提供灵活扩展点，允许子类继承或覆盖部分行为 | ✅ 使用 `virtual` 方法 |

---

## 💡 总结一句话：

> **抽象方法是“强制子类实现”，虚方法是“父类提供默认，子类可选覆盖”。**

你当前的 [LoggerDecorator](file://G:\RiderProjects\设计模式示例\6.装饰模式\LoggerDecorator.cs#L5-L19) 类中没有抽象方法，它是一个具体实现了 [Log](file://G:\RiderProjects\设计模式示例\6.装饰模式\LoggerDecorator.cs#L17-L19) 方法的抽象类，用于装饰器模式中封装接口对象。