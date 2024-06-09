
using System.Threading.Channels;
using DesignPattern.Command.Editor.ThirdPartyLib;

namespace DesignPattern.Command.Editor
{
    public class UndoCommand : IUndoableCommand
    {
        private readonly CommandHistory _commandHistory;

        public UndoCommand(CommandHistory commandHistory)
        {
            _commandHistory = commandHistory;
        }

        public void Execute()
        {   
            var currentCommand = _commandHistory.GetCurrentCommand();
            if(currentCommand != null && currentCommand is IUndoableCommand)
            {
                ((IUndoableCommand) currentCommand).UnExecute();
            }
        }

        public void UnExecute()
        {
            var currentCommand = _commandHistory.GetCurrentCommand();
            if(currentCommand != null && currentCommand is IUndoableCommand)
            {
                ((IUndoableCommand) currentCommand).Execute();
            }
        }
    }
}