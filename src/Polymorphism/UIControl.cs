namespace Polymorphism
{
    public abstract class UIControl
    {
        public void Enable()
        {
            Console.WriteLine("Enabled");
        }
        public abstract string Draw();
    }
}