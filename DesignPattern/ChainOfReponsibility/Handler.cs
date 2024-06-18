
namespace DesignPattern.ChainOfResponsibility
{
    public abstract class Hanlder
    {
        private Hanlder? _next;

        public Hanlder(Hanlder? next = null)
        {
            _next = next;
        }

        protected abstract bool DoHandle(HttpRequest httpRequest);
        public void Handle(HttpRequest httpRequest)
        {
            if(!DoHandle(httpRequest))
            {
                return;
            }  

            _next?.Handle(httpRequest);
        }

    }
}