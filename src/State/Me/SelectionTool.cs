namespace State.Me
{
    public class SelectionTool : ToolType
    {
        public override string OnMouseUp()
        {
            return "Draw dashed rectangle";
        }

        public override string OnMouseDown()
        {
            return "Selection icon";
        }
    }
}
