using Shouldly;
using State.Lesson;

namespace UnitTest.DesignPatterns.Behavioral.Memento;

public class State_LessonCanvasUnitTest
{
    [Fact]
    public void GivenCanvas_WhenISetSelectionTool_AndMouseDown_ThenItShouldPerformCorrectly()
    {
        var canvas = new Canvas();
        canvas.SetCurrentToolType(new SelectionTool());
        canvas.MouseDown().ShouldBeEquivalentTo(new SelectionTool().OnMouseDown());
    }

    [Fact]
    public void GivenCanvas_WhenISetSelectionTool_AndMouseUp_ThenItShouldPerformCorrectly()
    {
        var canvas = new Canvas();
        canvas.SetCurrentToolType(new SelectionTool());
        canvas.MouseUp().ShouldBeEquivalentTo(new SelectionTool().OnMouseUp());
    }

    [Fact]
    public void GivenCanvas_WhenISetEraserTool_AndMouseDown_ThenItShouldPerformCorrectly()
    {
        var canvas = new Canvas();
        canvas.SetCurrentToolType(new EraserTool());
        canvas.MouseDown().ShouldBeEquivalentTo(new EraserTool().OnMouseDown());
    }

    [Fact]
    public void GivenCanvas_WhenISetEraserTool_AndMouseUp_ThenItShouldPerformCorrectly()
    {
        var canvas = new Canvas();
        canvas.SetCurrentToolType(new EraserTool());
        canvas.MouseUp().ShouldBeEquivalentTo(new EraserTool().OnMouseUp());
    }

    [Fact]
    public void GivenCanvas_WhenISetBrushTool_AndMouseDown_ThenItShouldPerformCorrectly()
    {
        var canvas = new Canvas();
        canvas.SetCurrentToolType(new BrushTool());
        canvas.MouseDown().ShouldBeEquivalentTo(new BrushTool().OnMouseDown());
    }

    [Fact]
    public void GivenCanvas_WhenISetBrushTool_AndMouseUp_ThenItShouldPerformCorrectly()
    {
        var canvas = new Canvas();
        canvas.SetCurrentToolType(new BrushTool());
        canvas.MouseUp().ShouldBeEquivalentTo(new BrushTool().OnMouseUp());
    }
}