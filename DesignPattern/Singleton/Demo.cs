namespace DesignPattern.Singleton
{
    public static class Demo
    {
        public static void Play()
        {
            // We can not create new instance by using the new keyword
            var singleton = Singleton.GetInstance();
        }
    }
}