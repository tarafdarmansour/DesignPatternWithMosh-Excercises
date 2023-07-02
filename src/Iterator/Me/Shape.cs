namespace Iterator.Me;

public class Shape
{
    public Shape()
    {
    }

    public Shape(string name, int size)
    {
        Name = name;
        Size = size;
    }

    public string Name { get; set; }
    public int Size { get; set; }
}