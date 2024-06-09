namespace DesignPattern.Composite
{
    public class Group : Component
    {
        private List<Component> _components { get; set; }
        public Group()
        {
            this._components = new List<Component>();
        }
        public override void Render()
        {
            foreach (var component in this._components)
            {
                component.Render();
            }
        }

        public void Add(Component component)
        {
            this._components.Add(component);
        }
    }
}