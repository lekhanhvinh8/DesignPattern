namespace DesignPattern.Observer
{
    public abstract class Subject
    {
        public List<IObserver> Observers { get; set; }
        public Subject()
        {
            this.Observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            this.Observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            this.Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in this.Observers)
            {
                observer.Update();
            }
        }
    }
}