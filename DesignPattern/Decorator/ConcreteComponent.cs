namespace DesignPattern.Decorator
{
    public class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Basic Operator");
        }
    }
}