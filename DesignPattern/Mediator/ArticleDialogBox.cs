
namespace DesignPattern.Mediator
{
    public class ArticleDialogBox : DialogBox
    {
        private ListBox _articleListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public ArticleDialogBox()
        {
            this._articleListBox = new ListBox(this);
            this._titleTextBox = new TextBox(this);
            this._saveButton = new Button(this);
        }

        public override void Change(UIControl uiControl)
        {
            if(uiControl == _articleListBox)
            {
                articleSelected();
            }
            else if(uiControl == _titleTextBox)
            {
                titleChange();
            }
        }

        public void SimulateUserInteraction()
        {
            this._articleListBox.SetSelection("Article 1");
            Console.WriteLine("text box: " + _titleTextBox.GetContent());
            Console.WriteLine("button: " + _saveButton.GetEnabled());

            this._titleTextBox.SetContent("");
            Console.WriteLine("text box: " + _titleTextBox.GetContent());
            Console.WriteLine("button: " + _saveButton.GetEnabled());

            this._titleTextBox.SetContent("Article 2");
            Console.WriteLine("text box: " + _titleTextBox.GetContent());
            Console.WriteLine("button: " + _saveButton.GetEnabled());
        }

        private void articleSelected()
        { 
            _titleTextBox.SetContent(_articleListBox.GetSelection());
            _saveButton.SetEnabled(true);
        }

        private void titleChange()
        {
            var content = _titleTextBox.GetContent();
            var isEmpty = content == "" || content == null;

            _saveButton.SetEnabled(!isEmpty);
        }
    }
}