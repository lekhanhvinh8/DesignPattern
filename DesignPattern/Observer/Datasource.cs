namespace DesignPattern.Observer
{
    public class Datasource : Subject
    {
       private int _value;

       public int GetValue()
       {
            return _value;
       }

       public void SetValue(int value)
       {
            _value = value;
            NotifyObservers();
       }
    }
}