
namespace DesignPattern.Bridge
{
    public static class Demo
    {
        public static void Play()
        {
            var sonyRemoveControl = new RemoteControl(new SonyDevice());
            sonyRemoveControl.TurnOn();

            var sonyVideoRemoveControl = new VideoRemoteControl(new SonyDevice());
            sonyVideoRemoveControl.TurnOn();
            sonyVideoRemoveControl.Play();


            var lgRemoveControl = new RemoteControl(new LGDevice());
            lgRemoveControl.TurnOn();

            var lgVideoRemoveControl = new VideoRemoteControl(new LGDevice());
            lgVideoRemoveControl.TurnOn();
            lgVideoRemoveControl.Play();
        }
    }
}