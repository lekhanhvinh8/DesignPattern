using DesignPattern.FactoryMethod.MatchaLib;

namespace DesignPattern.FactoryMethod
{
    public class MatchaViewEngine : IViewEngine
    {
        public void Render(string context)
        {
            Console.WriteLine("MatchaViewEngine Render with context: " + context);
        }
    }
}