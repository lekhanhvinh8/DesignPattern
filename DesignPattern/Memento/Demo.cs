namespace DesignPattern.Memento
{
    public static class Demo
    {
        public static void Play()
        {
            var editor = new Editor();
            var history = new History();

            editor.Write("first text\n");
            history.Save(editor.GetCurrentState());

            editor.Write("second text\n");
            history.Save(editor.GetCurrentState());

            editor.Write("third text\n");
            editor.ShowCurrentContent();
            editor.Restore(history.Undo());
            editor.ShowCurrentContent();
            editor.Restore(history.Undo());
            editor.ShowCurrentContent();



        }

    }
}