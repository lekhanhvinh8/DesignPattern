namespace DesignPattern.Iterator
{
    public static class Demo
    {
        public static void Play()
        {
            var browserHistory = new BrowserHistory();
            browserHistory.Browse("url1");
            browserHistory.Browse("url2");
            browserHistory.Browse("url3");
            browserHistory.Browse("url4");

            var urlIterator = browserHistory.CreateItorator();
            while (urlIterator.HasNext())
            {
                Console.WriteLine(urlIterator.Current());
                urlIterator.MoveNext();
            }

        }

    }
}