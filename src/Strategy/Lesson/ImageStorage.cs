namespace Strategy.Lesson;

public class ImageStorage
{
    private string _compression; // Added to class for test purpose
    private string _filter; // Added to class for test purpose

    public void Store(string fileName, ICompressor compressor, IFilter filter)
    {
        _compression = compressor.Compress(fileName);
        _filter = filter.Apply(fileName);
    }

    public string GetCompression()
    {
        return _compression;
        // Added to class for test purpose
    }

    public string GetFilter()
    {
        return _filter;
        // Added to class for test purpose
    }
}