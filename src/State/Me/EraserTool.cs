namespace State.Me;

public class EraserTool : ToolType
{
    public override string OnMouseUp()
    {
        return "Eraser somethings";
    }

    public override string OnMouseDown()
    {
        return "Eraser icon";
    }
}