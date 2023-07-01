namespace State.First
{
    public class Canvas
    {
        private ToolType _currentToolType;
        public string MouseDown()
        {
            if (_currentToolType == ToolType.SELECTION)
                return "Selection icon";
            if (_currentToolType == ToolType.BRUSH)
                return "Brush icon";
            if (_currentToolType == ToolType.ERASER)
                return "Eraser icon";
            return "Unknown ToolType";
        }

        public string MouseUp()
        {
            if (_currentToolType == ToolType.SELECTION)
                return "Draw dashed rectangle";
            if (_currentToolType == ToolType.BRUSH)
                return "Draw a line";
            if (_currentToolType == ToolType.ERASER)
                return "Eraser somethings";
            return "Unknown ToolType";
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
}