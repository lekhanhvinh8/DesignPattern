namespace DesignPattern.State
{
    public class ConcreateStateB : IState
    {
         public void Handle(Context context)
        {
            context.State = new ConcreateStateA();
            Console.WriteLine("Handle By State B");
        }
    }
}