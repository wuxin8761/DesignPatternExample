// See https://aka.ms/new-console-template for more information

// 构建职责链

using _24.职责链模式;
using _24.职责链模式.SpecificApprover;

//  创建职责链
var teamLeader = new TeamLeader();
var departmentManager = new DepartmentManager();
var hr = new HR();

teamLeader.SetNext(departmentManager);
departmentManager.SetNext(hr);

// 发起请求
var request1 = new LeaveRequest { Employee = "Alice", Days = 2 };
teamLeader.ProcessRequest(request1);

var request2 = new LeaveRequest { Employee = "Bob", Days = 5 };
teamLeader.ProcessRequest(request2);

var request3 = new LeaveRequest { Employee = "Charlie", Days = 10 };
teamLeader.ProcessRequest(request3);