namespace DesignPattern.MediatorByObserver
{
    public class ListBox : UIControl
    {
        private string _selection = "";

        public void SetSelection(string selection)
        {
            this._selection = selection;
            NotifyObservers();
        }

        public string GetSelection()
        {
            return this._selection; 
        }

        public class ListBoxObserver : IObserver
        {
            private readonly Action _action;

            public ListBoxObserver(Action action)
            {
                this._action = action;
            }

            public void Update()
            { 
                _action.Invoke();
            }
        }
    }
}