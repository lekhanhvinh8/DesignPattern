namespace DesignPattern.Observer
{
    public static class Demo
    {
        public static void Play()
        {
            var datasource = new Datasource();
            var chart = new Chart(datasource);
            var spreadSheet = new SpreadSheet(datasource);

            datasource.AddObserver(chart);
            datasource.AddObserver(spreadSheet);

            datasource.SetValue(123);
            datasource.SetValue(234);
        }
    }
}