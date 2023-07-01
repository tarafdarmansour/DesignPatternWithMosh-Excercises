namespace State.Lesson;

public class Canvas
{
    private ITool _currentToolType;

    public string MouseDown()
    {
        return _currentToolType.OnMouseDown();
    }

    public string MouseUp()
    {
        return _currentToolType.OnMouseUp();
    }

    public ITool GetCurrentToolType()
    {
        return _currentToolType;
    }

    public void SetCurrentToolType(ITool toolType)
    {
        _currentToolType = toolType;
    }
}