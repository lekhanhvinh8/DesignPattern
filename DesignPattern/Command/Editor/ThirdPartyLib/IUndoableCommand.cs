
namespace DesignPattern.Command.Editor.ThirdPartyLib
{
    public interface IUndoableCommand : ICommand 
    {
       public void UnExecute();
    }
}