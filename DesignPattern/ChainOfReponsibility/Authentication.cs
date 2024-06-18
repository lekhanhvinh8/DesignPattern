
namespace DesignPattern.ChainOfResponsibility
{
    public class Authentication : Hanlder
    {
        public Authentication(Hanlder? next = null)
            : base(next)
        {
        }
        protected override bool DoHandle(HttpRequest httpRequest)
        {
            return Authenticate(httpRequest);
        }
        private bool Authenticate(HttpRequest httpRequest)
        {
            Console.WriteLine("Authentication");
            return httpRequest.UserName == "Admin" && httpRequest.Password == "123456";
        }
    }
}