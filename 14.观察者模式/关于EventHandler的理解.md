
// 定义一个事件
public event EventHandler<WeatherEventArgs> WeatherChanged;

在 C# 中，`EventHandler` 是一个**内置的委托类型（delegate）**，专门用于处理**事件（event）**。

---

## ✅ 一、定义

```csharp
public delegate void EventHandler(object sender, EventArgs e);
```


### 含义：

- 它是一个方法模板（委托），表示：
  > 这个方法接收两个参数：
    - `object sender`：表示触发事件的对象（即“谁发的通知”）
    - `EventArgs e`：表示事件数据（即“通知的内容”）
    - 没有返回值（`void`）

---

## ✅ 二、标准用途

`.NET` 和 `C#` 中很多系统类和框架都使用 `EventHandler` 来实现**观察者模式**。例如：

- Windows Forms 的按钮点击事件
- WPF 的 UI 控件交互
- Unity 中的 `UnityEvent`
- 自定义事件通信机制

---

## ✅ 三、为什么要用 `EventHandler`？

它是一种**标准化的事件处理方式**，具有以下优点：

| 优点 | 说明 |
|------|------|
| ✅ 统一接口 | 所有订阅这个事件的方法都要符合相同的签名 |
| ✅ 支持传递事件数据 | 使用 `EventArgs` 或其子类可以携带自定义信息 |
| ✅ 易于维护和扩展 | 符合 .NET 标准，方便团队协作和代码阅读 |

---

## ✅ 四、示例：使用 `EventHandler`

### 1. 定义一个事件发布者类

```csharp
public class Button
{
    // 定义一个事件，使用 EventHandler
    public event EventHandler Click;

    // 触发事件的方法
    public void OnClick()
    {
        Console.WriteLine("按钮被点击了！");
        Click?.Invoke(this, EventArgs.Empty); // 发送事件通知
    }
}
```


### 2. 订阅并处理事件

```csharp
class Program
{
    static void Main()
    {
        var button = new Button();

        // 订阅事件
        button.Click += Button_Click;

        // 触发事件
        button.OnClick();
    }

    // 事件处理函数
    private static void Button_Click(object sender, EventArgs e)
    {
        Console.WriteLine("收到了按钮点击事件！");
    }
}
```


### 🔧 输出结果：

```
按钮被点击了！
收到了按钮点击事件！
```


---

## ✅ 五、带参数的 `EventHandler<T>` 版本

如果你需要传递自定义的数据（比如天气变化、玩家血量等），可以使用泛型版本：

```csharp
public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);
```


### 示例：天气变化事件

#### 1. 自定义事件参数类

```csharp
public class WeatherEventArgs : EventArgs
{
    public string Weather { get; set; }

    public WeatherEventArgs(string weather)
    {
        Weather = weather;
    }
}
```


#### 2. 使用 `EventHandler<WeatherEventArgs>`

```csharp
public class WeatherService
{
    public event EventHandler<WeatherEventArgs> WeatherChanged;

    public void SetWeather(string weather)
    {
        Console.WriteLine("天气更新为：" + weather);
        OnWeatherChanged(new WeatherEventArgs(weather));
    }

    protected virtual void OnWeatherChanged(WeatherEventArgs e)
    {
        WeatherChanged?.Invoke(this, e);
    }
}
```


#### 3. 客户端订阅

```csharp
var service = new WeatherService();
service.WeatherChanged += (sender, e) =>
{
    Console.WriteLine("收到天气变化：" + e.Weather);
};

service.SetWeather("晴天");
```


### 📤 输出：

```
天气更新为：晴天
收到天气变化：晴天
```


---

## ✅ 六、总结

| 内容 | 说明 |
|------|------|
| `EventHandler` | 是一个标准委托，用于事件通信 |
| `object sender` | 表示事件的发起者（通常是 this） |
| `EventArgs e` | 表示事件数据，可为空（如 `EventArgs.Empty`） |
| `EventHandler<T>` | 泛型版本，支持自定义事件数据 |
| 常见用途 | UI 交互、状态变更、模块间通信、观察者模式 |

---

如果你想了解 `EventHandler` 在 Unity 中的实际应用（如角色受伤 → 更新 UI 血条），我也可以为你演示完整 Unity 示例。是否需要？