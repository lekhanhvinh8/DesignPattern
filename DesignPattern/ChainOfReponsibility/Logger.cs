
namespace DesignPattern.ChainOfResponsibility
{
    public class Logger : Hanlder
    {
        public Logger(Hanlder? next = null)
            : base(next)
        {
        }
        protected override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Logger");
            return true;
        }
        
    }
}