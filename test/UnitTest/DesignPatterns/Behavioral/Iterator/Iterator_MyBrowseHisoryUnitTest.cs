using Iterator.Me;
using Shouldly;

namespace UnitTest.DesignPatterns.Behavioral.Memento;

public class Iterator_MyBrowseHisoryUnitTest
{
    [Fact]
    public void GivenMyBrowseHistory_WhenIAddHistory_AndIterateHistory_ThenItShouldHasSameCountOfBrowseHistory()
    {
        var history = new BrowseHistory();
        history.Push("a");
        history.Push("b");
        history.Push("c");
        history.Push("d");
        var iterator = history.CreateIterator();
        var count = 0;
        while (iterator.HasNext())
        {
            count++;
            iterator.Next();
        }

        Assert.Equal(history.GetHistoryCount(), count);
    }

    [Fact]
    public void GivenMyBrowseHistory_WhenIAddHistory_AndIterateHistory_ThenItShouldHasAllHistoryItems()
    {
        var history = new BrowseHistory();
        string[] items = { "a", "b", "c", "d" };
        foreach (var item in items) history.Push(item);
        var iterator = history.CreateIterator();
        while (iterator.HasNext())
        {
            iterator.Current().ShouldBeOneOf(items);
            iterator.Next();
        }
    }
}