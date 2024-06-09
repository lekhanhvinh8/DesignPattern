namespace DesignPattern.TemplateMethod
{
    public class ConcreteClassA : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("A PrimitiveOperation1");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("A PrimitiveOperation2");

        }
    }
}