using DesignPattern.FactoryMethod.MatchaLib;

namespace DesignPattern.FactoryMethod
{
    public class MyController : Controller
    {
        protected override IViewEngine CreateViewEngine()
        {
            return new MyViewEngine();
        }
    }
}