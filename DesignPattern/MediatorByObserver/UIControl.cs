namespace DesignPattern.MediatorByObserver
{
    public abstract class UIControl
    {
        private List<IObserver> _obsersers;
        public UIControl()
        {
            _obsersers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            this._obsersers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._obsersers.Remove(observer);
        }

        protected void NotifyObservers()
        {
            foreach (var observer in _obsersers)
            {
                observer.Update();
            }
        }
    }
}