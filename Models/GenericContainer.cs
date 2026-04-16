public class GenericContainer<T>
{
    private T value;

    public void SetValue(T val)
    {
        value = val;
    }

    public T GetValue()
    {
        return value;
    }
}