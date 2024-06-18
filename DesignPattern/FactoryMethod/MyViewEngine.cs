using DesignPattern.FactoryMethod.MatchaLib;

namespace DesignPattern.FactoryMethod
{
    public class MyViewEngine : IViewEngine
    {
        public void Render(string context)
        {
            Console.WriteLine("MyEngine Render with context: " + context);
        }
    }
}