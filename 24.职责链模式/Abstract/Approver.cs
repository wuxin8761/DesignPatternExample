namespace _24.职责链模式;

// 定义抽象处理者
public abstract class Approver
{
    // 下一个处理者
    protected Approver _nextApprover;

    // 设置下一个处理者
    public void SetNext(Approver nextApprover)
    {
        _nextApprover = nextApprover;
    }

    // 处理请求
    public abstract void ProcessRequest(LeaveRequest request);
}

// 请求类
public class LeaveRequest
{
    public string Employee { get; set; }
    public int Days { get; set; }
}

