namespace DesignPattern.Adapter
{
    public static class Demo
    {
        public static void Play()
        {
            var image = new Image();
            var imageView = new ImageView(image);

            var normalFilter = new NormalFilter();
            imageView.ApplyFilter(normalFilter);

            var thirdPartyLibFilter = new ThirdPartyLibFilter();
            var thirdPartyLibFilterAdapter = new ThirdPartyLibFilterAdapter(thirdPartyLibFilter);
            // We can not use thirdPartyLibFilter because it's interface is not expect the paramter of ApplyFilter method.
            // so we create an adapter take thirdPartyLibFilter, and implement IFilter (expect the parameter).
            imageView.ApplyFilter(thirdPartyLibFilterAdapter);
        }
    }
}