namespace Strategy.Lesson;

public class BlackAndWhiteFilter : IFilter
{
    public string Apply(string fileName)
    {
        return "Applying B&W filter";
    }
}