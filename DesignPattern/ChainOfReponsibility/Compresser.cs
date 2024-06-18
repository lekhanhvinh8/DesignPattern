
namespace DesignPattern.ChainOfResponsibility
{
    public class Compresser : Hanlder
    {
        public Compresser(Hanlder? next = null)
            : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Compresser");
            return true;
        }
        
    }
}