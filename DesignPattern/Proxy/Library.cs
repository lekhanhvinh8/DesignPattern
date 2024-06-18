namespace DesignPattern.Proxy
{
    public class Library
    {
        private Dictionary<string, IEbook> _eBooks { get; set; }
        public Library()
        {
            _eBooks = new Dictionary<string, IEbook>();
            LoadEbookFromDisk();
        }

        public void LoadEbookFromDisk()
        {
            var ebooksFromDisk = new List<string>(){"a", "b", "c", "d"};
            foreach (var ebookName in ebooksFromDisk)
            {
                // In stead of loading the real ebook (may contain a lot of information, we create a proxy, 
                // Then when the client really use the action, we create the real ebook to process it.)
                _eBooks.Add(ebookName, new LazyLoadEbookProxy(ebookName));
            }
        }

        public IEbook GetBook(string name)
        {
            return _eBooks[name];
        }
    }
}