namespace DesignPattern.Flyweight
{
    public static class Demo
    {
        public static void Play()
        {
            // We stored shared data and resue it
            var pointImageFactory = new PointImageFactory();

            var point1 = new Point(1, 2, pointImageFactory.GetCachePointImage(1));
            var point2 = new Point(3, 4, pointImageFactory.GetCachePointImage(1));

            if(point1.PointImage == point2.PointImage)
            {
                Console.WriteLine("It is the pattern. PointImage is the same object in memory, it save a lot of memory");
            }
            else
            {
                Console.WriteLine("We fail !!!");
            }
        }

    }
}