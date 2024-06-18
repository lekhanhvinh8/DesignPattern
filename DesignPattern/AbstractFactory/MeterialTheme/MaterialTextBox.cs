using DesignPattern.AbstractFactory.Widget;

namespace DesignPattern.AbstractFactory.MaterialTheme
{
    public class MaterialTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Render a Material TextBox");
        }
    }
}