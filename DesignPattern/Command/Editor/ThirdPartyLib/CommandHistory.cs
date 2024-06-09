
namespace DesignPattern.Command.Editor.ThirdPartyLib
{
    public class CommandHistory 
    {
       public List<ICommand> _commands;
       public int? CurrentIndex { get; set; }

       public CommandHistory()
       {
            this._commands = new List<ICommand>();
       }

       public void Push(ICommand command)
       {
            if(this._commands.Count == 0)
            {
                CurrentIndex = 0;
            }
            else {
                if(CurrentIndex < this._commands.Count - 1)
                {
                    _commands.RemoveRange((int)CurrentIndex + 1, _commands.Count - ((int)CurrentIndex + 1));
                }

                CurrentIndex++;
            }

            this._commands.Add(command);
       }

       public ICommand? GetCurrentCommand()
       {
            if(CurrentIndex == null)
            {
                return null;
            }

            return _commands[(int)CurrentIndex];
       }

       public IUndoableCommand? Undo()
       {
            if(CurrentIndex == null)
            {
                return null;
            }

            var currentCommand = _commands[(int)CurrentIndex];

            if(currentCommand is not IUndoableCommand)
            {
                return null;
            }

            if(CurrentIndex > 0)
            {
                CurrentIndex--;
            }
            else
            {
                CurrentIndex = null;
            }
            
            return currentCommand as IUndoableCommand;
       }
    }
}