单一职责原则（Single Responsibility Principle, SRP）是面向对象设计中的一个核心原则，其定义为：

> 一个类应该只有一个引起它变化的原因。

换句话说，一个类或模块只应负责一项职责。这有助于提高代码的可维护性、可读性和可测试性。

---

### 示例：违反单一职责原则

以下是一个**违反 SRP** 的示例：

```csharp
public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    // 负责计算薪资
    public double CalculateBonus()
    {
        return Salary * 0.1;
    }

    // 负责日志记录
    public void Log()
    {
        Console.WriteLine($"Employee: {Name}, Salary: {Salary}");
    }

    // 负责数据持久化
    public void Save()
    {
        // 模拟保存到数据库
        Console.WriteLine("Saving employee data...");
    }
}
```


上述 `Employee` 类承担了多个职责：
- 计算奖金（业务逻辑）
- 日志记录（日志功能）
- 数据存储（持久化）

如果其中任何一个功能发生变化，都需要修改这个类，违反了 SRP。

---

### 示例：遵循单一职责原则

将上面的例子重构为多个类，每个类只负责一项职责：

#### 1. 核心实体类（仅表示员工信息）

```csharp
public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
}
```


#### 2. 薪资和奖金计算类

```csharp
public class SalaryCalculator
{
    public double CalculateBonus(Employee employee)
    {
        return employee.Salary * 0.1;
    }
}
```


#### 3. 日志记录类

```csharp
public class Logger
{
    public void Log(Employee employee)
    {
        Console.WriteLine($"Employee: {employee.Name}, Salary: {employee.Salary}");
    }
}
```


#### 4. 数据访问类（持久化）

```csharp
public class EmployeeRepository
{
    public void Save(Employee employee)
    {
        Console.WriteLine($"Saving employee data: {employee.Name}");
    }
}
```


#### 使用方式

```csharp
var employee = new Employee { Name = "Alice", Salary = 8000 };

var calculator = new SalaryCalculator();
double bonus = calculator.CalculateBonus(employee);

var logger = new Logger();
logger.Log(employee);

var repository = new EmployeeRepository();
repository.Save(employee);
```


---

### 总结

| 项目 | 描述 |
|------|------|
| **优点** | 提高了可维护性、可测试性；降低了类之间的耦合度 |
| **缺点** | 可能增加类的数量，但结构更清晰 |
| **适用场景** | 所有需要良好设计的类都应该遵循 SRP |

通过这种方式，每个类都只做一件事，符合“单一职责原则”。

SRP 是 单一职责原则（Single Responsibility Principle） 的缩写，它是面向对象设计五大基本原则之一（SOLID 中的 S）。
定义
一个类应该只有一个引起它变化的原因。
换句话说，一个类或模块应当只负责完成一项职责，而不是承担多个互不相关的任务。

核心思想
提高类的内聚性：将相关的职责集中在一起。
降低类之间的耦合度：减少因某个功能变动而影响多个类的情况。
提升代码的可维护性、可读性、可测试性。