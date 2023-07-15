using Command.Lesson;
using Shouldly;

namespace UnitTest.DesignPatterns.Behavioral.Command;

public class Command_AddCustomerCommandUnitTest
{
    [Fact]
    public void
        GivenCustomerService_WhenIClickButtonInitializedByCommandService_ItShouldBeEqualCallingAddCustomerService()
    {
        var service = new CustomerService();
        var command = new AddCustomerCommand(service);
        var button = new Button(command);
        button.Click().ShouldBeEquivalentTo(service.AddCustomer());
    }
}