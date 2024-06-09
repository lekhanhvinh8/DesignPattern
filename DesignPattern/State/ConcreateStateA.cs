namespace DesignPattern.State
{
    public class ConcreateStateA : IState
    {
        public void Handle(Context context)
        {
            context.State = new ConcreateStateB();
            Console.WriteLine("Handle By State A");
        }
    }
}