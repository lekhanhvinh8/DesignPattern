namespace DesignPattern.MediatorByObserver
{
    public static class Demo
    {
        public static void Play()
        {
            var dialog = new ArticleDialogBox();
            dialog.SimulateUserInteraction();
        }
    }
}