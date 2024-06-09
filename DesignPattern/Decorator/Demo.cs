namespace DesignPattern.Decorator
{
    public static class Demo
    {
        public static void Play()
        {
            // I just add additional code from decorate1 and decorate2 to concreate component's Operation method without modify it's content
            var concreateComponent = new ConcreteComponent();
            var decorate1 = new Decorator1(concreateComponent);
            var decorate2 = new Decorator1(decorate1);

            decorate2.Operation();
        }
    }
}