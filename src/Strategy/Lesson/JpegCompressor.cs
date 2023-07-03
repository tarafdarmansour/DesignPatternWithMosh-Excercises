namespace Strategy.Lesson;

public class JpegCompressor : ICompressor
{
    public string Compress(string fileName)
    {
        return "Compressing using Jpeg";
    }
}