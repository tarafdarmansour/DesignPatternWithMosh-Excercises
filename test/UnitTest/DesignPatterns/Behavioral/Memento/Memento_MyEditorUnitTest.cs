using Memento;
using Shouldly;

namespace UnitTest.DesignPatterns.Behavioral.Memento
{
    public class Memento_MyEditorUnitTest
    {
        [Fact]
        public void GivenMyEditor_WhenISetContent2Times_AndUndo_ThenItShouldUndoText()
        {
            MyEditor myEditor = new MyEditor();
            string firstValue = "First Step";
            string secondValue = "Second Step";
            myEditor.SetContent(firstValue);
            myEditor.SetContent(secondValue);
            myEditor.Undo();
            myEditor.GetContent().ShouldBeEquivalentTo(firstValue);
        }
    }
}
