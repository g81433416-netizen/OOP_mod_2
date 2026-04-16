// Обобщённый класс (generic), который может хранить значение любого типа T
public class GenericContainer<T>
{
    // Приватное поле для хранения значения
    private T value;

    // Метод для установки значения
    public void SetValue(T val)
    {
        value = val;
    }

    // Метод для получения значения
    public T GetValue()
    {
        return value;
    }
}
