namespace TemplateMethod.Lesson;

public class AuditTrail
{
    //activities parameter add to test purpose
    public void record(List<string> activities)
    {
        activities.Add("Audit");
    }
}