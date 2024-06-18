namespace DesignPattern.Bridge
{
    public class SonyDevice : IDevice
    {
        public void Play()
        {
            Console.WriteLine("Sony Play");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony TurnOff");

        }

        public void TurnOn()
        {
            Console.WriteLine("Sony TurnOn");

        }
    }
}