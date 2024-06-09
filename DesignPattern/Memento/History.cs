namespace DesignPattern.Memento
{
    // Caretaker
    public class History
    {
        private readonly IList<EditorState> _states;
        public History()
        {
            this._states = new List<EditorState>();
        }

        public void Save(EditorState state)
        {
            this._states.Add(state);
        }

        public EditorState? Undo()
        {
            if(this._states.Count > 0)
            {
                var lastState = this._states[this._states.Count-1];
                this._states.Remove(lastState);
                return lastState;
            }

            return null;
        }
    }
}