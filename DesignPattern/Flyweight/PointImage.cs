namespace DesignPattern.Flyweight
{
    public class PointImage
    {
        public int PointType { get; set; }
        public byte[] Image { get; set; }

        public PointImage(int pointType, byte[] image)
        {
            this.PointType = pointType;
            this.Image = image;
        }

    }
}