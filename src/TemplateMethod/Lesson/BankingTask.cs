namespace TemplateMethod.Lesson;

public abstract class BankingTask
{
    private readonly AuditTrail _auditTrail;

    public BankingTask()
    {
        _auditTrail = new AuditTrail();
    }

    //activities parameter add to test purpose
    public void Execute(List<string> activities)
    {
        _auditTrail.record(activities);
        DoExecute(activities);
    }

    protected abstract void DoExecute(List<string> activities);
}