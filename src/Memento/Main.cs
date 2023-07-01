using Memento.Me;

namespace Memento
{
    public class Main
    {
        public static void main(MyEditor myEditor)
        {
            myEditor.SetContent("a");
            myEditor.SetContent("b");
            myEditor.SetContent("c");
            myEditor.Undo();
        }
    }
}
