namespace DesignPattern.Singleton
{
    public class Singleton
    {
        private static Singleton? _instance { get; set; }
        private Singleton()
        {
            
        }

        public static Singleton GetInstance()
        {
            if( _instance == null)
            {
                _instance = new Singleton();
                return _instance;
            }

            return _instance;
        }
    }
}