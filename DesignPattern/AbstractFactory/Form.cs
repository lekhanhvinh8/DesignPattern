namespace DesignPattern.AbstractFactory
{
    public class Form
    {
        public void Render(IWidgetFactory factory)
        {
            var textbox = factory.CreateTextBox();
            var button = factory.CreateButton();

            textbox.Render();
            button.Render();
        }
    }
}