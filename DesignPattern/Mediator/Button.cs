namespace DesignPattern.Mediator
{
    public class Button : UIControl
    {
        private bool _Enabled;

        public Button(DialogBox dialogBox) : base(dialogBox)
        {
        }

        public void SetEnabled(bool enabled)
        {
            this._Enabled = enabled;
            this._owner.Change(this);
        }

        public string GetEnabled()
        {
            return this._Enabled.ToString(); 
        }

    }
}