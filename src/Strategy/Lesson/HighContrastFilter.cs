namespace Strategy.Lesson;

public class HighContrastFilter : IFilter
{
    public string Apply(string fileName)
    {
        return "Applying HighContrast filter";
    }
}