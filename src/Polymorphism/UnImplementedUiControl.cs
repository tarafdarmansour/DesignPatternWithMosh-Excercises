namespace Polymorphism;

public class UnImplementedUiControl : UIControl
{
    public override string Draw()
    {
        throw new NotImplementedException();
    }
}