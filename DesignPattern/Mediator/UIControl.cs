namespace DesignPattern.Mediator
{
    public abstract class UIControl
    {
        protected readonly DialogBox _owner;

        public UIControl(DialogBox dialogBox)
        {
            this._owner = dialogBox;
        }
    }
}