using DesignPattern.AbstractFactory.Widget;

namespace DesignPattern.AbstractFactory.AntTheme
{
    public class AntThemeFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new AntButton();
        }

        public ITextBox CreateTextBox()
        {
            return new AntTextBox();

        }
       
    }
}