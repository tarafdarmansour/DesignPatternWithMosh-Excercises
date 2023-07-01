using Memento.Exercise;
using Shouldly;

namespace UnitTest.DesignPatterns.Behavioral.Memento
{
    public class Memento_ExerciseEditorUnitTest
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
        public void GivenEditor_WhenISetFontSize2Times_AndRestoreOneTime_ThenItShouldUndoText()
        {
            var editor = new Editor();
            var history = new History();
            var firstValue = 1;
            var secondValue = 2;
            editor.SetFontSize(firstValue);
            history.Push(editor.CreateState());
            editor.SetFontSize(secondValue);

            editor.Restore(history.Pop());
            editor.GetFontSize().ShouldBeEquivalentTo(firstValue);
        }

        [Fact]
        public void GivenEditor_WhenISetFontName2Times_AndRestoreOneTime_ThenItShouldUndoText()
        {
            var editor = new Editor();
            var history = new History();
            var firstValue = "Shiraz";
            var secondValue = "Vazir";
            editor.SetFontName(firstValue);
            history.Push(editor.CreateState());
            editor.SetFontName(secondValue);

            editor.Restore(history.Pop());
            editor.GetFontName().ShouldBeEquivalentTo(firstValue);
        }
    }
}
