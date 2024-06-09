namespace DesignPattern.Observer
{
    public class Chart : IObserver 
    {
       private Datasource _datasource;

        public Chart(Datasource datasource)
        {
            _datasource = datasource;
        }

        public void Update()
        {
            Console.WriteLine("Chart updated: " + _datasource.GetValue().ToString());
        }
    }
}