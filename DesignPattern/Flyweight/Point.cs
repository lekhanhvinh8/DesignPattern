namespace DesignPattern.Flyweight
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointImage PointImage { get; set; }

        public Point(int x, int y, PointImage image)
        {
            this.X = x;
            this.Y = y;
            this.PointImage = image;
        }

    }
}