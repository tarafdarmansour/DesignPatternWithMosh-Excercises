namespace Command.Lesson;

public class Button
{
    private readonly ICommand _command;
    private string _label;

    public Button(ICommand command)
    {
        _command = command;
    }

    public string Click()
    {
        return _command.Execute();
    }

    public string GetLabel()
    {
        return _label;
    }

    public void SetLabel(string label)
    {
        _label = label;
    }
}