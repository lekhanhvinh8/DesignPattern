namespace DesignPattern.Visitor
{
    public interface IOperation
    {
        public void Apply(HeadingNode node);
        public void Apply(AnchorNode node);
    }
}