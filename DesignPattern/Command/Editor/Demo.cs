
using DesignPattern.Command.Editor.ThirdPartyLib;

namespace DesignPattern.Command.Editor
{
    public static class Demo
    {
        public static void Play()
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.SetContent("<div>ABC</div>");
            var editor = new ThirdPartyLib.Editor(new CommandHistory());
            
            Console.WriteLine(htmlDoc.GetContent());

            editor.Action(new BoldCommand(htmlDoc));
            Console.WriteLine(htmlDoc.GetContent());

            editor.Action(new BoldCommand(htmlDoc));
            Console.WriteLine(htmlDoc.GetContent());

            editor.Undo();
            Console.WriteLine(htmlDoc.GetContent());

            editor.Undo();
            Console.WriteLine(htmlDoc.GetContent());

            editor.Action(new BoldCommand(htmlDoc));
            Console.WriteLine(htmlDoc.GetContent());
        }
    }
}