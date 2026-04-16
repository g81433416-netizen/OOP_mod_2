public static class Comparer<T> where T : System.IComparable<T>
{
    public static T Max(T a, T b)
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    public static T Min(T a, T b)
    {
        return a.CompareTo(b) < 0 ? a : b;
    }
}