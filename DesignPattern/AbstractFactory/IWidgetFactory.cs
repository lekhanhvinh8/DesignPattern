using DesignPattern.AbstractFactory.Widget;

namespace DesignPattern.AbstractFactory
{
    public interface IWidgetFactory
    {
        public IButton CreateButton();
        public ITextBox CreateTextBox();
    }
}