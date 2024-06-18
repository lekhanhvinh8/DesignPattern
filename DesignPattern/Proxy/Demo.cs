namespace DesignPattern.Proxy
{
    public static class Demo
    {
        public static void Play()
        {
            var library = new Library();
            var bookA = library.GetBook("a");
            bookA.Show();

            var bookB = library.GetBook("b");
            bookB.Show();

        }
    }
}