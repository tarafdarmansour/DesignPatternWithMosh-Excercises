using Iterator.Me;
using Shouldly;

namespace UnitTest.DesignPatterns.Behavioral.Iterator;

public class Iterator_MyShapeCollectionHisoryUnitTest
{
    [Fact]
    public void GivenBrowseHistory_WhenIAddHistory_AndIterateHistory_ThenItShouldHasSameCountOfBrowseHistory()
    {
        var history = new ShapeCollection();
        history.Push(new Shape("a", 1));
        history.Push(new Shape("b", 2));
        history.Push(new Shape("c", 3));
        history.Push(new Shape("d", 4));
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
    public void GivenBrowseHistory_WhenIAddHistory_AndIterateHistory_ThenItShouldHasAllHistoryItems()
    {
        var history = new ShapeCollection();
        Shape[] items =
        {
            new("a", 1),
            new("b", 2),
            new("c", 3),
            new("d", 4)
        };
        foreach (var item in items) history.Push(item);
        var iterator = history.CreateIterator();
        while (iterator.HasNext())
        {
            iterator.Current().ShouldBeOneOf(items);
            iterator.Next();
        }
    }
}