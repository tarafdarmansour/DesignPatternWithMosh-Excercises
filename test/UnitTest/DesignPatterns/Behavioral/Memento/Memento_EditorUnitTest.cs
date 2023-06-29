using Memento;
using Shouldly;

namespace UnitTest.DesignPatterns.Behavioral.Memento
{
    public class Memento_EditorUnitTest
    {
        [Fact]
        public void GivenEditor_WhenISetContent2Times_AndRestoreOneTime_ThenItShouldUndoText()
        {
            Editor editor = new Editor();
            History history = new History();
            string firstValue = "First Step";
            string secondValue = "Second Step";
            editor.SetContent(firstValue);
            history.Push(editor.CreateState());
            editor.SetContent(secondValue);

            editor.Restore(history.Pop());
            editor.GetContent().ShouldBeEquivalentTo(firstValue);
        }


        [Fact]
        public void GivenEditor_WhenISetContent2Times_AndNotRestore_ThenItShouldBeLastText()
        {
            Editor editor = new Editor();
            History history = new History();
            string firstValue = "First Step";
            string secondValue = "Second Step";
            editor.SetContent(firstValue);
            history.Push(editor.CreateState());
            editor.SetContent(secondValue);

            editor.GetContent().ShouldBeEquivalentTo(secondValue);
        }
    }
}
