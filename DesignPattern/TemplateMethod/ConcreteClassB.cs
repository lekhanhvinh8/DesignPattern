namespace DesignPattern.TemplateMethod
{
    public class ConcreteClassB : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("B PrimitiveOperation1");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("B PrimitiveOperation2");
        }

        protected override void Hook()
        {
            Console.WriteLine("Specific Hook of B");
        }
    }
}