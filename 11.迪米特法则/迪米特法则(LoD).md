迪米特法则（Law of Demeter，LoD）是面向对象设计中的一个重要原则，也被称为**最少知识原则（Least Knowledge Principle）**
。它的核心思想是：一个对象应该对其他对象有尽可能少的了解，只和“直接的朋友”通信。

---

### 迪米特法则的核心规则

一个类应该只与以下几类对象交互：

1. **自身（this）**
2. **方法的参数（method parameters）**
3. **自身创建的对象（通过 new 创建的对象）**
4. **自身属性对象（成员变量）**
5. **全局对象（如静态对象或单例）**

> 不要“链式调用”访问其他对象的对象，例如避免 `a.getB().getC().doSomething()` 这种写法。

---

### 举个例子

#### ❌ 违反迪米特法则的例子：

```csharp
public class Person {
    private Car car;

    public Car getCar() {
        return car;
    }
}

public class Car {
    public Engine engine;

    public Engine getEngine() {
        return engine;
    }
}

public class Engine {
    public void start() {
        Console.WriteLine("Engine started.");
    }
}
```

如果我们在客户端这样调用：

```csharp
Person person = new Person();
person.getCar().getEngine().start(); // 违反了迪米特法则
```

问题在于：`Person` 对象暴露了内部结构，客户端需要知道 `Car` 和 `Engine` 的存在，违反了封装性。

---

#### ✅ 遵循迪米特法则的改进方式：

```csharp
public class Person {
    private Car car;

    public void startCar() {
        car.start();
    }
}

public class Car {
    private Engine engine = new Engine();

    public void start() {
        engine.start();
    }
}

public class Engine {
    public void start() {
        Console.WriteLine("Engine started.");
    }
}
```

客户端只需调用：

```csharp
Person person = new Person();
person.startCar(); // 符合迪米特法则
```

---

### 迪米特法则的优点

| 优点            | 描述                   |
|---------------|----------------------|
| 🔒 **降低耦合度**  | 类之间依赖减少，更容易维护和扩展     |
| 🔄 **提高可复用性** | 类不依赖外部结构，易于在不同上下文中复用 |
| 🧩 **增强封装性**  | 内部实现细节对外隐藏，避免误操作     |

---

### 注意事项

- 迪米特法则不是完全禁止链式调用，而是强调**不要过度暴露对象的内部结构**。
- 实际开发中应根据业务需求权衡是否严格遵循该原则，避免过度设计。

如果你提供具体的代码片段（如 C#），我可以帮你具体分析并优化以符合迪米特法则。