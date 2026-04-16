// Обобщённый класс с ограничением:
// T должен уметь сравниваться (реализовывать IComparable)
public static class Comparer<T> where T : System.IComparable<T>
{
    // Метод для нахождения максимума
    public static T Max(T a, T b)
    {
         // CompareTo:
        // > 0 → a больше b
        // < 0 → a меньше b
        return a.CompareTo(b) > 0 ? a : b;
    }
    
    // Метод для нахождения минимума
    public static T Min(T a, T b)
    {
        return a.CompareTo(b) < 0 ? a : b;
    }
}
