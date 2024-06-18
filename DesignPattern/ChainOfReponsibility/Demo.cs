
namespace DesignPattern.ChainOfResponsibility
{
    public static class Demo
    {
        public static void Play()
        {
            var compresser = new Compresser(null);
            var logger = new Logger(compresser);
            var authentication = new Authentication(logger);

            var webServer = new WebServer(authentication);

            // Right password
            webServer.Handle(new HttpRequest() {UserName = "Admin", Password = "123456"});

            // Wrong password
            webServer.Handle(new HttpRequest() {UserName = "Admin", Password = "12345"});

        }
    }
}