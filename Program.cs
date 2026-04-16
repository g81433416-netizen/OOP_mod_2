using System;

class Program
{
    static void Main()
    {
        var floatContainer = new GenericContainer<float>();
        floatContainer.SetValue(3.14f);
        Console.WriteLine(floatContainer.GetValue());

        var boolContainer = new GenericContainer<bool>();
        boolContainer.SetValue(true);
        Console.WriteLine(boolContainer.GetValue());

        int a = 5, b = 10;
        Utils.Swap(ref a, ref b);
        Console.WriteLine($"{a}, {b}");

        string s1 = "Hello", s2 = "World";
        Utils.Swap(ref s1, ref s2);
        Console.WriteLine($"{s1}, {s2}");

        Utils.PrintCollection(new int[] { 1, 2, 3 });
        Utils.PrintCollection(new string[] { "A", "B", "C" });

        Console.WriteLine(Comparer<int>.Max(5, 10));
        Console.WriteLine(Comparer<int>.Min(5, 10));

        Console.WriteLine(Comparer<double>.Max(2.5, 1.1));
        Console.WriteLine(Comparer<string>.Max("A", "B"));

        var result1 = CreatePerson("Саша", 21);
        var result2 = CreatePerson("", -21);

        Console.WriteLine(result1.IsSuccess ? result1.Value : result1.Error);
        Console.WriteLine(result2.IsSuccess ? result2.Value : result2.Error);
    }
//хехехе
    static OperationResult<Person> CreatePerson(string name, int age)
    {
        if (string.IsNullOrEmpty(name))
        return OperationResult<Person>.Failure("Имя пустое");

        if (age < 0)
        return OperationResult<Person>.Failure("Возраст отрицательный");

        return OperationResult<Person>.Success(new Person { Name = name, Age = age });
    }
}