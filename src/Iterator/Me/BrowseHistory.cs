namespace Iterator.Me;

public class BrowseHistory : MyIteratable<string>
{
    private readonly Stack<string> _urls = new();

    public void Push(string shape)
    {
        _urls.Push(shape);
    }

    public string Pop()
    {
        return _urls.Pop();
    }

    public int GetHistoryCount()
    {
        return _urls.Count;
    }

    public MyIterator<string> CreateIterator()
    {
        return new ListIterator(this);
    }

    public class ListIterator : MyIterator<string>
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