namespace DesignPattern.Adapter
{
    public class ThirdPartyLibFilterAdapter : IFilter
    {
        private readonly ThirdPartyLibFilter _filter;

        public ThirdPartyLibFilterAdapter(ThirdPartyLibFilter filter)
        {
            this._filter = filter;
        }
        public void Filter()
        {
            this._filter.FilterDifferentWay();
        }
    }
    
}