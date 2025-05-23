namespace _24.职责链模式.SpecificApprover;

// HR
// 处理者实现
public class HR : Approver
{
    public override void ProcessRequest(LeaveRequest request)
    {
        // 处理逻辑
        // 如果请假天数大于7天，则直接批准，否则传递给下一个处理者
        Console.WriteLine($"HR approved {request.Employee}'s leave for {request.Days} days.");
    }
}