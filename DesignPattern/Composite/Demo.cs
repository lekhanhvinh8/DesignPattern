namespace DesignPattern.Composite
{
    public static class Demo
    {
        public static void Play()
        {
            var rectangle = new Rectangle();
            var circle = new Circle();
            var shape = new Shape();

            var group = new Group();
            group.Add(rectangle);
            group.Add(circle);
            group.Add(shape);

            rectangle.Render();
            group.Render();
        }
    }
}