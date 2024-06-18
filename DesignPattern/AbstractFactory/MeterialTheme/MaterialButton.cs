using DesignPattern.AbstractFactory.Widget;

namespace DesignPattern.AbstractFactory.MaterialTheme
{
    public class MaterialButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render a Material Button");
        }
    }
}