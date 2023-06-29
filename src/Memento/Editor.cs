﻿namespace Memento
{
    public class Editor
    {
        private string _content;

        public EditorState CreateState()
        {
            return new EditorState(_content);
        }

        public void Restore(EditorState state)
        {
            _content = state.GetContent();
        }
        public string GetContent()
        {
            return _content;
        }

        public void SetContent(string content)
        {
            _content = content;
        }

    }
}