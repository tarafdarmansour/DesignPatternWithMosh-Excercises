namespace TemplateMethod.Lesson;

public class TransferMoneyTask : BankingTask
{
    //activities parameter add to test purpose
    protected override void DoExecute(List<string> activities)
    {
        activities.Add("Transfer Money");
    }
}