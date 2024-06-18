
namespace DesignPattern.ChainOfResponsibility
{
    public class WebServer
    {
        private Hanlder _hanlder;

        public WebServer(Hanlder handler)
        {
            this._hanlder = handler;
        }

        public void Handle(HttpRequest httpRequest)
        {
            _hanlder.Handle(httpRequest);
        }

    }
}