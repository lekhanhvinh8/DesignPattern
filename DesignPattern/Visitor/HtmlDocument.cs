
namespace DesignPattern.Visitor
{
    public class HtmlDocument
    {
        private List<IHtmlNode> _nodes;

        public HtmlDocument()
        {
            _nodes = new List<IHtmlNode>();
        }

        public void AddNode(IHtmlNode node)
        {
            this._nodes.Add(node);
        }

        public void ApplyAllNodes(IOperation operation)
        {
            foreach (var node in _nodes)
            {
                node.Execute(operation);
            }
        }
    }    
}