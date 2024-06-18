using DesignPattern.AbstractFactory.Widget;

namespace DesignPattern.AbstractFactory.AntTheme
{
    public class AntButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render a Ant Button");
        }
    }
}