namespace Iterator.Me;

public interface MyIteratable<T>
{
    void Push(T shape);
    T Pop();
    int GetHistoryCount();
    MyIterator<T> CreateIterator();
}