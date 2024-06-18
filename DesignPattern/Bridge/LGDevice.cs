namespace DesignPattern.Bridge
{
    public class LGDevice : IDevice
    {
        public void Play()
        {
            Console.WriteLine("LG Not support playing");
        }

        public void TurnOff()
        {
            Console.WriteLine("LG TurnOff");

        }

        public void TurnOn()
        {
            Console.WriteLine("LG TurnOn");

        }
    }
}