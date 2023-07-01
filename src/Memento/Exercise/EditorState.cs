
namespace Memento.Exercise
{
    public class EditorState
    {
        private readonly string _content;
        private readonly string _fontName;
        private readonly int _fontSize;
        public EditorState(string content, string fontName,int fontSize)
        {
            _content = content;
            _fontName = fontName;
            _fontSize = fontSize;
        }

        public string GetContent()
        {
            return _content;
        }

        public int GetFontSize()
        {
            return _fontSize;
        }

        public string GetFontName()
        {
            return _fontName;
        }
    }
}
