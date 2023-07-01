namespace Memento.Exercise
{
    public class History
    {
        private Stack<EditorState> states = new Stack<EditorState>();

        public void Push(EditorState state)
        {
            states.Push(state);
        }

        public EditorState Pop()
        {
            return states.Pop();
        }
    }
}
