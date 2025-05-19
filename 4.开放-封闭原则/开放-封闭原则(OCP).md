开放-封闭原则（Open-Closed Principle, OCP）是面向对象设计中的另一个重要原则，其定义为：

> **软件实体（类、模块、函数等）应该对扩展开放，对修改关闭。**

这意味着一个类或模块在实现功能后，应该能够在不修改原有代码的情况下进行功能扩展。

---

### 核心思想

- **开放**：允许通过继承、组合或插件机制等方式对系统行为进行扩展。
- **封闭**：已有代码一旦完成并通过测试，就不应轻易改动，以降低引入错误的风险。

---

### 示例说明（使用 C#）

#### ❌ 违反 OCP 的例子：

假设我们有一个 `DiscountCalculator` 类，用于根据客户类型计算折扣：

```csharp
public enum CustomerType
{
    Regular,
    Premium
}

public class DiscountCalculator
{
    public double GetDiscount(double price, CustomerType type)
    {
        if (type == CustomerType.Regular)
        {
            return price * 0.1;
        }
        else if (type == CustomerType.Premium)
        {
            return price * 0.2;
        }

        throw new ArgumentException("Unknown customer type");
    }
}
```


**问题**：
- 每当新增一种客户类型时，都需要修改 `GetDiscount` 方法。
- 违反了“对修改关闭”的原则。

---

#### ✅ 遵循 OCP 的重构方式：

我们可以使用多态和策略模式来重构这段代码，使其符合 OCP。

##### 1. 定义接口：

```csharp
public interface IDiscountStrategy
{
    double ApplyDiscount(double price);
}
```


##### 2. 实现不同策略类：

```csharp
public class RegularCustomerDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price * 0.1;
    }
}

public class PremiumCustomerDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price * 0.2;
    }
}
```


##### 3. 使用上下文调用策略：

```csharp
public class DiscountCalculator
{
    private IDiscountStrategy _strategy;

    public void SetStrategy(IDiscountStrategy strategy)
    {
        _strategy = strategy;
    }

    public double GetDiscount(double price)
    {
        if (_strategy == null)
            throw new InvalidOperationException("未设置折扣策略");

        return _strategy.ApplyDiscount(price);
    }
}
```


##### 4. 使用示例：

```csharp
var calculator = new DiscountCalculator();

// 对于普通客户
calculator.SetStrategy(new RegularCustomerDiscount());
Console.WriteLine($"Regular discount price: {calculator.GetDiscount(100)}"); // 输出 90

// 对于高级客户
calculator.SetStrategy(new PremiumCustomerDiscount());
Console.WriteLine($"Premium discount price: {calculator.GetDiscount(100)}"); // 输出 80
```


---

### 优点总结

| 优势 | 描述 |
|------|------|
| 可扩展性 | 新增功能只需添加新类，无需修改已有逻辑 |
| 稳定性 | 已有代码不会因为新增功能而被改动，减少出错风险 |
| 易维护性 | 各个策略独立存在，易于理解和测试 |

---

### 应用场景

- 需要根据不同条件执行不同行为的系统（如支付方式、折扣策略、日志级别等）
- 期望长期维护且频繁迭代的项目
- 希望通过插件化、模块化提升灵活性的架构设计

---

### 小结

开放-封闭原则强调的是通过抽象（接口或基类）和多态来实现系统的可扩展性，避免直接修改已有代码。结合策略模式、装饰器模式等设计模式可以很好地实现该原则。