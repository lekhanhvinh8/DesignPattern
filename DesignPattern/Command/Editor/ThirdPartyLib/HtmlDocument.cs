
namespace DesignPattern.Command.Editor.ThirdPartyLib
{
    public class HtmlDocument 
    {
       private string _content;
       
       public HtmlDocument()
       {
            this._content = "";
       }

       public void MakeBold()
       {
            this._content = "<b>" + this._content + "</b>";
       }

       public string GetContent()
       {
            return this._content;
       }
       public void SetContent(String content)
       {
            this._content = content;
       }
    }
}