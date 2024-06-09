
using DesignPattern.Command.Editor.ThirdPartyLib;

namespace DesignPattern.Command.Editor
{
    public class BoldCommand : IUndoableCommand
    {
        private string? _previousContent;
        private readonly HtmlDocument _document;

        public BoldCommand(HtmlDocument document)
        {
            _document = document;
        }

        public void Execute()
        {   
            _previousContent = _document.GetContent();
            _document.MakeBold();
        }

        public void UnExecute()
        {
            if(_previousContent != null)
            {
                _document.SetContent(_previousContent);
            }
        }
    }
}