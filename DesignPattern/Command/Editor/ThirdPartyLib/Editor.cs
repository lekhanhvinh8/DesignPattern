
namespace DesignPattern.Command.Editor.ThirdPartyLib
{
    public class Editor 
    {
        public readonly CommandHistory History;

        public Editor(CommandHistory history)
        {
            this.History = history;
        }

        public void Action(ICommand command)
        {
            command.Execute();
            History.Push(command);
        }

        public void Undo()
        {
            var undoCommand = History.Undo();
            undoCommand?.UnExecute();
        }

        public void Replay(int index)
        {
            //
        }
    }
}