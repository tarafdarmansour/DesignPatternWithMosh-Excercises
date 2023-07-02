namespace Iterator.Me;

public interface MyIterator<T>
{
    bool HasNext();
    T Current();
    void Next();
}