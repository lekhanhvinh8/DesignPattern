namespace DesignPattern.Flyweight
{
    public class PointImageFactory
    {
        private readonly Dictionary<int, PointImage> _pointImage;

        public PointImageFactory()
        {
            this._pointImage = new Dictionary<int, PointImage>();
        }

        public PointImage GetCachePointImage(int key)
        {
            PointImage? pointImage;
            this._pointImage.TryGetValue(key, out pointImage);

            if(pointImage == null)
            {
                Console.WriteLine("The value not found in cached Dictionary. Creating new value");

                var newPointImage = new PointImage(key, new byte[1000]);
                this._pointImage.Add(key, newPointImage);

                return newPointImage;
            }
            else
            {
                Console.WriteLine("The value was cached");
            }

            return pointImage;
        }

    }
}