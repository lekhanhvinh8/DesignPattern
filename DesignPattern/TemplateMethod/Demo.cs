namespace DesignPattern.TemplateMethod
{
    public static class Demo
    {
        public static void Play()
        {
            // concreateClassA and concreateClassB have somthing common. But also have somthing specific.

            var concreateClassA = new ConcreteClassA();
            concreateClassA.TemplateMethod();

            var concreateClassB = new ConcreteClassB();
            concreateClassB.TemplateMethod();
        }
    }
}