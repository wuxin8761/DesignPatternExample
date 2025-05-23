namespace _24.职责链模式.SpecificApprover;
// 团队主管
// 处理者实现
public class TeamLeader : Approver
{
    // 处理请求
    public override void ProcessRequest(LeaveRequest request)
    {
        // 如果请假天数小于等于3天，则直接批准，否则传递给下一个处理者
        if (request.Days <= 3)
        {
            Console.WriteLine($"Team Leader approved {request.Employee}'s leave for {request.Days} days.");
        }
        else if (_nextApprover != null)
        {
            _nextApprover.ProcessRequest(request);
        }
    }
}