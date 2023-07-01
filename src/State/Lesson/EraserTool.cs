namespace State.Lesson;

public class EraserTool : ITool
{
    public string OnMouseUp()
    {
        return "Eraser somethings";
    }

    public string OnMouseDown()
    {
        return "Eraser icon";
    }
}