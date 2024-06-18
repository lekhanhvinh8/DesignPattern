namespace DesignPattern.Visitor
{
    public static class Demo
    {
        public static void Play()
        {
            // Just use the pattern when the object stucture is stable/
            // Like html node. It's all have about 2x nodes. So stable
            // The expand is the operation apply to the nodes. So we could use Visitor pattern in the case

            var htmlDocument = new HtmlDocument();
            htmlDocument.AddNode(new HeadingNode());
            htmlDocument.AddNode(new AnchorNode());

            var highlightOperation = new HighLightOperation();
            var plainTextOperation = new PlainTextOperation();

            htmlDocument.ApplyAllNodes(highlightOperation);
            htmlDocument.ApplyAllNodes(plainTextOperation);
        }
    }
}