namespace DesignPattern.Proxy
{
    public class RealEbook : IEbook
    {
        private string _name;

        public RealEbook(string name)
        {
            Console.WriteLine("Initialize the Real Ebook" + _name);
            _name = name;
        }
    
        public void Show()
        {
            Console.WriteLine("Showing Ebook: " + _name);
        }
    }
}