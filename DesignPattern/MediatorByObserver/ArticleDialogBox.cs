using static DesignPattern.MediatorByObserver.ListBox;
using static DesignPattern.MediatorByObserver.TextBox;

namespace DesignPattern.MediatorByObserver
{
    public class ArticleDialogBox
    {
        private ListBox _articleListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public ArticleDialogBox()
        {
            this._articleListBox = new ListBox();
            this._articleListBox.Attach(new ListBoxObserver(articleSelected));

            this._titleTextBox = new TextBox();
            this._titleTextBox.Attach(new TextBoxObserver(titleChange));

            this._saveButton = new Button();
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