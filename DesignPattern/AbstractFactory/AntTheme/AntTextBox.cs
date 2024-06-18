using DesignPattern.AbstractFactory.Widget;

namespace DesignPattern.AbstractFactory.AntTheme
{
    public class AntTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Render a Ant TextBox");
        }
    }
}