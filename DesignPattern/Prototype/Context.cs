namespace DesignPattern.Prototype
{
    public class Context
    {
        public IComponent Duplicate(IComponent componnent)
        {
            var newComponent = componnent.Clone();
            return newComponent;
        }
    }
}