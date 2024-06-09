namespace DesignPattern.Adapter
{
    public class ImageView
    {
        private readonly Image _image;

        public ImageView(Image image)
        {
            this._image = image;
        }

        public void ApplyFilter(IFilter filter)
        {
            filter.Filter();
        }
    }
    
}