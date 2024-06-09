namespace DesignPattern.Observer
{
    public class SpreadSheet : IObserver 
    {
       private Datasource _datasource;

        public SpreadSheet(Datasource datasource)
        {
            _datasource = datasource;
        }

        public void Update()
        {
            Console.WriteLine("SpreadSheet updated: " + _datasource.GetValue().ToString());
        }
    }
}