namespace DesignPattern.FactoryMethod
{
    public static class Demo
    {
        public static void Play()
        {
            // The controller leave it engine for the subclass to create, we may or not override it, if not override, we will use the default engine which is MatChaEngine.
            var myController = new MyController();
            myController.Render("context1");
        }

    }
}