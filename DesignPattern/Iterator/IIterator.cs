namespace DesignPattern.Iterator
{
    public interface IIterator<T>
    {
        public T Current();
        public bool HasNext();
        public void MoveNext();
        public void Reset();
    }
}