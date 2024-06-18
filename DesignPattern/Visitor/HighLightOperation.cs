namespace DesignPattern.Visitor
{
    public class HighLightOperation : IOperation
    {
        public void Apply(HeadingNode node)
        {
            Console.WriteLine("Hight Light Heading");
        }

        public void Apply(AnchorNode node)
        {
            Console.WriteLine("Hight Light Anchor");

        }
    }
}