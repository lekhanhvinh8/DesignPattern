namespace DesignPattern.State
{
    public static class Demo
    {
        public static void Play()
        {
            var context = new Context(new ConcreateStateA());
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }
    }
}