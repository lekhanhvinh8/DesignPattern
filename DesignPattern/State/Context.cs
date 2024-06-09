namespace DesignPattern.State
{
    public class Context
    {
        public IState State { get; set; }
        public Context(IState state)
        {
            this.State = state;
        }

        public void Request()
        {
            this.State.Handle(this);
        }
    }
}