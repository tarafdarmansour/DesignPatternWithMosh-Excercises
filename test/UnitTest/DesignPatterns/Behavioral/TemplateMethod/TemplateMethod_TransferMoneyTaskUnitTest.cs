using Shouldly;
using TemplateMethod.Lesson;

namespace UnitTest.DesignPatterns.Behavioral.TemplateMethod;

public class TemplateMethod_TransferMoneyTaskUnitTest
{
    [Fact]
    public void GivenTransferMoney_WhenIExecuteTask_ThenItShouldContainAuditOperation()
    {
        var activities = new List<string>();
        var task = new TransferMoneyTask();
        task.Execute(activities);
        activities.ShouldContain("Audit");
    }

    [Fact]
    public void GivenTransferMoney_WhenIExecuteTask_ThenItShouldContainTransferOperation()
    {
        var activities = new List<string>();
        var task = new TransferMoneyTask();
        task.Execute(activities);
        activities.ShouldContain("Transfer Money");
    }

    [Fact]
    public void GivenTransferMoney_WhenIExecuteTask_ThenItShouldContainAuditOperationAtFirst()
    {
        var activities = new List<string>();
        var task = new TransferMoneyTask();
        task.Execute(activities);
        activities[0].ShouldBeEquivalentTo("Audit");
    }
}