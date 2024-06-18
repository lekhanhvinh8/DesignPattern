namespace DesignPattern.Prototype
{
    public class Square : IComponent
    {
        public Square()
        {
        }

        public void Render()
        {
            Console.WriteLine("Render a Square");
        }

        public IComponent Clone()
        {
            var newSquare = new Square();
            return newSquare;
        }
    }
}