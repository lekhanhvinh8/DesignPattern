namespace DesignPattern.Adapter
{
    public class NormalFilter : IFilter
    {
        public void Filter()
        {
            Console.WriteLine("Normal filter");
        }
    }
    
}