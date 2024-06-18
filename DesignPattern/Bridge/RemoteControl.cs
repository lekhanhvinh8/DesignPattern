namespace DesignPattern.Bridge
{
    public class RemoteControl
    {
        private readonly IDevice _device;

        public RemoteControl(IDevice device)
        {
            this._device = device;
        }
        public void TurnOn()
        {
            _device.TurnOn();
        }

        public void TurnOff()
        {
            _device.TurnOff();
        }
    }
}