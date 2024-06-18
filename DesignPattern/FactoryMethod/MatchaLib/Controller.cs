using DesignPattern.FactoryMethod.MatchaLib;

namespace DesignPattern.FactoryMethod
{
    public class Controller
    {
        public void Render(string context)
        {
            var viewEngine = CreateViewEngine();
            viewEngine.Render(context);
        }

        protected virtual IViewEngine CreateViewEngine()
        {
            return new MatchaViewEngine();
        }
    }
}