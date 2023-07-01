namespace Memento.Me
{
    public class MyEditor
    {
        List<string> _contentHistory = new List<string>();
        int _index = 0;

        public string GetContent()
        {
            return _contentHistory[_index];
        }

        public void SetContent(string content)
        {
            _contentHistory.Add(content);
            _index = _contentHistory.Count - 1;
        }

        public void Undo()
        {
            _index--;
        }
    }
}