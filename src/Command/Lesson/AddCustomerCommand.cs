namespace Command.Lesson;

public class AddCustomerCommand : ICommand
{
    private readonly CustomerService _customerService;

    public AddCustomerCommand(CustomerService customerService)
    {
        _customerService = customerService;
    }

    public string Execute()
    {
        return _customerService.AddCustomer();
    }
}