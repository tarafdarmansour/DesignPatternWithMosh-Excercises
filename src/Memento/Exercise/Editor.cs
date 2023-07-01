namespace Memento.Exercise
{
    public class Editor
    {
        private string _content;
        private string _fontName;
        private int _fontSize;

        public EditorState CreateState()
        {
            return new EditorState(_content, _fontName, _fontSize);
        }

        public void Restore(EditorState state)
        {
            _content = state.GetContent();
            _fontName = state.GetFontName();
            _fontSize = state.GetFontSize();
        }
        public string GetContent()
        {
            return _content;
        }
        public void SetContent(string content)
        {
            _content = content;
        }
        public string GetFontName()
        {
            return _fontName;
        }
        public void SetFontName(string fontName)
        {
            _fontName = fontName;
        }
        public int GetFontSize()
        {
            return _fontSize;
        }
        public void SetFontSize(int fontSize)
        {
            _fontSize = fontSize;
        }
    }
}