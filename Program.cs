using System;

class Program
{
    static void Main()
    {
        // ===== 1. Проверка GenericContainer =====
        var floatContainer = new GenericContainer<float>();
        floatContainer.SetValue(3.14f); //записываем значения
        Console.WriteLine(floatContainer.GetValue()); //выводим

        var boolContainer = new GenericContainer<bool>();
        boolContainer.SetValue(true);
        Console.WriteLine(boolContainer.GetValue());

        // ===== 2. Проверка Swap =====
        int a = 5, b = 10;
        Utils.Swap(ref a, ref b); //меняем местами
        Console.WriteLine($"{a}, {b}");

        string s1 = "Hello", s2 = "World";
        Utils.Swap(ref s1, ref s2);
        Console.WriteLine($"{s1}, {s2}");

        // ===== 3. Проверка PrintCollection =====
        Utils.PrintCollection(new int[] { 1, 2, 3 });
        Utils.PrintCollection(new string[] { "A", "B", "C" });
        
        // ===== 4. Проверка Comparer =====
        Console.WriteLine(Comparer<int>.Max(5, 10));
        Console.WriteLine(Comparer<int>.Min(5, 10));

        Console.WriteLine(Comparer<double>.Max(2.5, 1.1));
        Console.WriteLine(Comparer<string>.Max("A", "B"));

        // ===== 5. Проверка OperationResult =====
        var result1 = CreatePerson("Саша", 21); //корректный ввод
        var result2 = CreatePerson("", -21); //ошибка

        // Если успех → выводим объект, иначе ошибку
        Console.WriteLine(result1.IsSuccess ? result1.Value : result1.Error);
        Console.WriteLine(result2.IsSuccess ? result2.Value : result2.Error);
    }
    
    // Метод создания объекта Person с проверками
    static OperationResult<Person> CreatePerson(string name, int age)
    {
        // проверка имени
        if (string.IsNullOrEmpty(name))
        return OperationResult<Person>.Failure("Имя пустое");

        //проверка возврата
        if (age < 0)
        return OperationResult<Person>.Failure("Возраст отрицательный");

        // Если всё хорошо — создаём объект
        return OperationResult<Person>.Success(new Person { Name = name, Age = age });
    }
}
