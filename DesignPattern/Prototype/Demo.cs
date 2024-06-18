namespace DesignPattern.Prototype
{
    public static class Demo
    {
        public static void Play()
        {
            var context = new Context();
            var circle = new Circle(1);
            var square = new Square();

            circle.Render();
            square.Render();

            var duplicateCircle = context.Duplicate(circle);
            var duplicateSquare = context.Duplicate(square);

            duplicateCircle.Render();
            duplicateSquare.Render();
        }
    }
}