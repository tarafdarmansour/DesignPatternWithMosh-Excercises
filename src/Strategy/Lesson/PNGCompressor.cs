namespace Strategy.Lesson;

public class PNGCompressor : ICompressor
{
    public string Compress(string fileName)
    {
        return "Compress using PNG";
    }
}