namespace DesignPattern.Iterator 
{
    public class BrowserHistory
    {
        // Very easy to change the Type of List to others (Enumerable, Stack, Array,...) with no impact to the Client
        private List<string> urls;
        public BrowserHistory()
        {
            this.urls = new List<string>();
        }
        public void Browse(string urls)
        {
            this.urls.Add(urls);
        }

        public UrlIterator CreateItorator()
        {
            return new UrlIterator(this);
        }

        public class UrlIterator : IIterator<string?>
        {
            private BrowserHistory _browserHistory;
            private int _index;
            public UrlIterator(BrowserHistory browserHistory)
            {
                this._browserHistory = browserHistory;
            }

            public string? Current()
            {
                if(_browserHistory.urls.Count() == 0)
                {
                    return null;
                }

                return _browserHistory.urls[this._index];
            }

            public bool HasNext()
            {
                return _index < _browserHistory.urls.Count();
            }

            public void MoveNext()
            {
                this._index++;
            }

            public void Reset()
            {
                if(_index > 0)
                {
                    _index--;
                }
            }
        }
    }
}