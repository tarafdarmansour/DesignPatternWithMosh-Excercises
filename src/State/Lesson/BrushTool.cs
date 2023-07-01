namespace State.Lesson;

public class BrushTool : ITool
{
    public string OnMouseUp()
    {
        return "Draw a line";
    }

    public string OnMouseDown()
    {
        return "Brush icon";
    }
}