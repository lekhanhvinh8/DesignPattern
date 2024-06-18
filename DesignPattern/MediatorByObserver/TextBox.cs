namespace DesignPattern.MediatorByObserver
{
    public class TextBox : UIControl
    {
        private string _content = "";

        public void SetContent(string content)
        {
            this._content = content;
            NotifyObservers();
        }

        public string GetContent()
        {
            return this._content; 
        }

        public class TextBoxObserver : IObserver
        {
            private readonly Action _action;

            public TextBoxObserver(Action action)
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