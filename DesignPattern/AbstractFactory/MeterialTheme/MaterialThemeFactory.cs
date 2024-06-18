using DesignPattern.AbstractFactory.Widget;

namespace DesignPattern.AbstractFactory.MaterialTheme
{
    public class MaterialThemeFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new MaterialButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MaterialTextBox();

        }
    }
}