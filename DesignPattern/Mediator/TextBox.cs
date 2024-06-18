namespace DesignPattern.Mediator
{
    public class TextBox : UIControl
    {
        private string _content = "";

        public TextBox(DialogBox dialogBox) : base(dialogBox)
        {
        }

        public void SetContent(string content)
        {
            this._content = content;
            this._owner.Change(this);
        }

        public string GetContent()
        {
            return this._content; 
        }
    }
}