namespace DesignPattern.Decorator
{
    public class Decorator1 : IComponent
    {
        private readonly IComponent _component;

        public Decorator1(IComponent component)
        {
            this._component = component;
        }
        public void Operation()
        {
            Console.WriteLine("Decorate1 Operator");
            _component.Operation();
        }
    }
}