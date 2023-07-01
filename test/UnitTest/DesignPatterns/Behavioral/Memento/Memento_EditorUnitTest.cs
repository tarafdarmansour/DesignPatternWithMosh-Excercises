using Memento.Lesson;
using Shouldly;

namespace UnitTest.DesignPatterns.Behavioral.Memento
{
    public class Memento_EditorUnitTest
    {
        [Fact]
        public void GivenEditor_WhenISetContent2Times_AndRestoreOneTime_ThenItShouldUndoText()
        {
            var editor = new Editor();
            var history = new History();
            var firstValue = "First Step";
            var secondValue = "Second Step";
            editor.SetContent(firstValue);
            history.Push(editor.CreateState());
            editor.SetContent(secondValue);

            editor.Restore(history.Pop());
            editor.GetContent().ShouldBeEquivalentTo(firstValue);
        }


        [Fact]
        public void GivenEditor_WhenISetContent2Times_AndNotRestore_ThenItShouldBeLastText()
        {
            var editor = new Editor();
            var history = new History();
            var firstValue = "First Step";
            var secondValue = "Second Step";
            editor.SetContent(firstValue);
            history.Push(editor.CreateState());
            editor.SetContent(secondValue);

            editor.GetContent().ShouldBeEquivalentTo(secondValue);
        }
    }
}
