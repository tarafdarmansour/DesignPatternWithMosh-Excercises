namespace State.Lesson;

public class SelectionTool : ITool
{
    public string OnMouseUp()
    {
        return "Draw dashed rectangle";
    }

    public string OnMouseDown()
    {
        return "Selection icon";
    }
}