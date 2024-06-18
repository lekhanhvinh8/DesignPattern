using DesignPattern.AbstractFactory.AntTheme;
using DesignPattern.AbstractFactory.MaterialTheme;

namespace DesignPattern.AbstractFactory
{
    public static class Demo
    {
        public static void Play()
        {
           var materialFactory = new MaterialThemeFactory();
           var antFactory = new AntThemeFactory();

           var form = new Form();
           form.Render(materialFactory);
           form.Render(antFactory);

        }
    }
}