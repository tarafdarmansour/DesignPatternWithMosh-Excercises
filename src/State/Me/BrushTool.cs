namespace State.Me;

public class BrushTool : ToolType
{
    public override string OnMouseUp()
    {
        return "Draw a line";
    }

    public override string OnMouseDown()
    {
        return "Brush icon";
    }
}