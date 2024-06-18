namespace DesignPattern.MediatorByObserver
{
    public class Button : UIControl
    {
        private bool _Enabled;

        public void SetEnabled(bool enabled)
        {
            this._Enabled = enabled;
            NotifyObservers();
        }

        public string GetEnabled()
        {
            return this._Enabled.ToString(); 
        }

    }
}