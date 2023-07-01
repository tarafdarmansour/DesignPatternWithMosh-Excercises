namespace State.Me;

public class MyCanvas
{
    private ToolType _currentToolType;

    public string MouseDown()
    {
        return _currentToolType.OnMouseDown();
    }

    public string MouseUp()
    {
        return _currentToolType.OnMouseUp();
    }

    public ToolType GetCurrentToolType()
    {
        return _currentToolType;
    }

    public void SetCurrentToolType(ToolType toolType)
    {
        _currentToolType = toolType;
    }
}