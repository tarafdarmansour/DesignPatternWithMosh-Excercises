using Shouldly;
using State.Me;

namespace UnitTest.DesignPatterns.Behavioral.Memento;

public class State_MyCanvasUnitTest
{
    [Fact]
    public void GivenMyCanvas_WhenISetSelectionTool_AndMouseDown_ThenItShouldPerformCorrectly()
    {
        var myCanvas = new MyCanvas();
        myCanvas.SetCurrentToolType(new SelectionTool());
        myCanvas.MouseDown().ShouldBeEquivalentTo(new SelectionTool().OnMouseDown());
    }

    [Fact]
    public void GivenMyCanvas_WhenISetSelectionTool_AndMouseUp_ThenItShouldPerformCorrectly()
    {
        var myCanvas = new MyCanvas();
        myCanvas.SetCurrentToolType(new SelectionTool());
        myCanvas.MouseUp().ShouldBeEquivalentTo(new SelectionTool().OnMouseUp());
    }

    [Fact]
    public void GivenMyCanvas_WhenISetEraserTool_AndMouseDown_ThenItShouldPerformCorrectly()
    {
        var myCanvas = new MyCanvas();
        myCanvas.SetCurrentToolType(new EraserTool());
        myCanvas.MouseDown().ShouldBeEquivalentTo(new EraserTool().OnMouseDown());
    }

    [Fact]
    public void GivenMyCanvas_WhenISetEraserTool_AndMouseUp_ThenItShouldPerformCorrectly()
    {
        var myCanvas = new MyCanvas();
        myCanvas.SetCurrentToolType(new EraserTool());
        myCanvas.MouseUp().ShouldBeEquivalentTo(new EraserTool().OnMouseUp());
    }

    [Fact]
    public void GivenMyCanvas_WhenISetBrushTool_AndMouseDown_ThenItShouldPerformCorrectly()
    {
        var myCanvas = new MyCanvas();
        myCanvas.SetCurrentToolType(new BrushTool());
        myCanvas.MouseDown().ShouldBeEquivalentTo(new BrushTool().OnMouseDown());
    }

    [Fact]
    public void GivenMyCanvas_WhenISetBrushTool_AndMouseUp_ThenItShouldPerformCorrectly()
    {
        var myCanvas = new MyCanvas();
        myCanvas.SetCurrentToolType(new BrushTool());
        myCanvas.MouseUp().ShouldBeEquivalentTo(new BrushTool().OnMouseUp());
    }
}