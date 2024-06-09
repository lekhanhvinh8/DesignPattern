namespace DesignPattern.Memento
{
    //Originator
    public class Editor
    {
        private string _content { get; set; }
        private string _title { get; set; }
        private object? _somethingElseOfAnEditor {get; set;}

        public Editor()
        {
            this._content = "";
            this._title = "";
        }

        public void Write(string content)
        {
            this._content += content;
        }

        public void ShowCurrentContent()
        {
            Console.WriteLine(this._content);
        }

        public EditorState GetCurrentState()
        {
            return new EditorState(this._content, this._title);
        }

        public void Restore(EditorState? state)
        {
            this._content = state?.Content ?? "";
            this._title = state?.Title ?? "";
        }
    }
}