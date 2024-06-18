namespace DesignPattern.Proxy
{
    public class LazyLoadEbookProxy : IEbook
    {
        private string _name;
        private RealEbook? _realEbook;

        public LazyLoadEbookProxy(string name)
        {
            _name = name;
        }

        public void Show()
        {
            if(_realEbook == null)
            {
                _realEbook = new RealEbook(_name);
            }

            _realEbook.Show();
            
        }
    }
}