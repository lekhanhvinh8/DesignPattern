namespace DesignPattern.Decorator
{
    public class Decorator2 : IComponent
    {
        private readonly IComponent _component;

        public Decorator2(IComponent component)
        {
            this._component = component;
        }
        public void Operation()
        {
            Console.WriteLine("Decorator2 Operator");
            _component.Operation();
        }
    }
}