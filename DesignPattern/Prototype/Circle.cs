namespace DesignPattern.Prototype
{
    public class Circle : IComponent
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void Render()
        {
            Console.WriteLine("Render a Circle: " + Radius.ToString());
        }

        public IComponent Clone()
        {
            var newCircle = new Circle(Radius);
            return newCircle;
        }
    }
}