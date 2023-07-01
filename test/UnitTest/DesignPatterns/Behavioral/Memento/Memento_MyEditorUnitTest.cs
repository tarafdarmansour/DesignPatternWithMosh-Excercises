using Memento.Me;
using Shouldly;

namespace UnitTest.DesignPatterns.Behavioral.Memento
{
    public class Memento_MyEditorUnitTest
    {
        [Fact]
        public void GivenMyEditor_WhenISetContent2Times_AndUndo_ThenItShouldUndoText()
        {
            var myEditor = new MyEditor();
            var firstValue = "First Step";
            var secondValue = "Second Step";
            myEditor.SetContent(firstValue);
            myEditor.SetContent(secondValue);
            myEditor.Undo();
            myEditor.GetContent().ShouldBeEquivalentTo(firstValue);
        }
    }
}
