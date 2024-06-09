namespace DesignPattern.TemplateMethod
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Console.WriteLine("Method.");
            PrimitiveOperation1();
            PrimitiveOperation2();
            Hook();
        }

        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();
        protected virtual void Hook()
        {
            Console.WriteLine("default hook");
        }
    }
}