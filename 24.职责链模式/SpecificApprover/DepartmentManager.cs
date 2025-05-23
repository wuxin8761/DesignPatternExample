namespace _24.职责链模式.SpecificApprover;

// 部门经理
// 处理者实现
public class DepartmentManager : Approver
{
    // 处理请求
    public override void ProcessRequest(LeaveRequest request)
    {
        // 如果请假天数小于等于7天，则直接批准，否则传递给下一个处理者
        if (request.Days <= 7)
        {
            Console.WriteLine($"Department Manager approved {request.Employee}'s leave for {request.Days} days.");
        }
        else if (_nextApprover != null)
        {
            _nextApprover.ProcessRequest(request);
        }
    }
}