namespace DesignPattern.Bridge
{
    public class VideoRemoteControl : RemoteControl
    {
        private readonly IDevice _device;

        public VideoRemoteControl(IDevice device)
            : base(device)
        {
            this._device = device;
        }
        public void Play()
        {
            _device.Play();
        }
    }
}