namespace DesignPattern.Memento
{
    // Memento
    public class EditorState
    {
        public string Content { get; set; }
        public string Title { get; set; }

        public EditorState(string content, string title)
        {
            this.Content = content;
            this.Title = title;
        }
    }
}