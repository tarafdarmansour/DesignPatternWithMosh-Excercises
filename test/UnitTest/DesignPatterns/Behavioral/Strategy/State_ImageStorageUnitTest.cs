using Shouldly;
using Strategy.Lesson;

namespace UnitTest.DesignPatterns.Behavioral.Strategy;

public class State_ImageStorageUnitTest
{
    [Fact]
    public void
        GivenImageStorage_WhenIStoreAnImage_AndIUseJpegCompressor_ThenTheCompressorOfImageStorageShouldBeJpegCompressor()
    {
        var fileName = "a.jpg";
        var imageStorage = new ImageStorage();
        imageStorage.Store(fileName, new JpegCompressor(), new BlackAndWhiteFilter());
        imageStorage.GetCompression().ShouldBeEquivalentTo(new JpegCompressor().Compress(fileName));
    }

    [Fact]
    public void
        GivenImageStorage_WhenIStoreAnImage_AndIUseBlackAndWhiteFilter_ThenTheFilterOfImageStorageShouldBeBlackAndWhiteFilter()
    {
        var fileName = "a.jpg";
        var imageStorage = new ImageStorage();
        imageStorage.Store(fileName, new JpegCompressor(), new BlackAndWhiteFilter());
        imageStorage.GetFilter().ShouldBeEquivalentTo(new BlackAndWhiteFilter().Apply(fileName));
    }
}