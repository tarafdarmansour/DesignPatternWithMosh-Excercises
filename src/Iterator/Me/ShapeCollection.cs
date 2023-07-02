namespace Iterator.Me;

public class ShapeCollection : MyIteratable<Shape>
{
    private readonly Stack<Shape> _collection = new();

    public void Push(Shape shape)
    {
        _collection.Push(shape);
    }

    public Shape Pop()
    {
        return _collection.Pop();
    }

    public int GetHistoryCount()
    {
        return _collection.Count;
    }

    public MyIterator<Shape> CreateIterator()
    {
        return new ListIterator(this);
    }

    public class ListIterator : MyIterator<Shape>
    {
        private readonly ShapeCollection _shapeCollection;
        private int _index;

        public ListIterator(ShapeCollection shapeCollection)
        {
            _shapeCollection = shapeCollection;
        }

        public bool HasNext()
        {
            return _index < _shapeCollection._collection.Count;
        }

        public void Next()
        {
            _index++;
        }

        public Shape Current()
        {
            return _shapeCollection._collection.ToArray()[_index];
        }
    }
}