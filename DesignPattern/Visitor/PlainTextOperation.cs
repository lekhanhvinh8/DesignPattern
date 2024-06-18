namespace DesignPattern.Visitor
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode node)
        {
            Console.WriteLine("PlainText Heading");
        }

        public void Apply(AnchorNode node)
        {
            Console.WriteLine("PlainText Anchor");

        }
    }
}