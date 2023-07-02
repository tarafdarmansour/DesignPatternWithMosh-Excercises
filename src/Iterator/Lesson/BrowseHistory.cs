namespace Iterator.Lesson;

public class BrowseHistory
{
    private readonly Stack<string> _urls = new();

    public void Push(string url)
    {
        _urls.Push(url);
    }

    public string Pop()
    {
        return _urls.Pop();
    }

    public int GetHistoryCount()
    {
        return _urls.Count;
    }

    public MyIterator CreateIterator()
    {
        return new ListIterator(this);
    }

    public class ListIterator : MyIterator
    {
        private readonly BrowseHistory _history;
        private int _index;

        public ListIterator(BrowseHistory history)
        {
            _history = history;
        }

        public bool HasNext()
        {
            return _index < _history._urls.Count;
        }

        public string Current()
        {
            return _history._urls.ToArray()[_index];
        }

        public void Next()
        {
            _index++;
        }
    }
}