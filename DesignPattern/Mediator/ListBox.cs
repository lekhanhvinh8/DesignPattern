namespace DesignPattern.Mediator
{
    public class ListBox : UIControl
    {
        private string _selection = "";

        public ListBox(DialogBox owner)
            : base(owner)
        {
            
        }

        public void SetSelection(string selection)
        {
            this._selection = selection;
            this._owner.Change(this);
        }

        public string GetSelection()
        {
            return this._selection; 
        }
    }
}