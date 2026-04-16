using System;
using System.Collections.Generic;

// Статический класс с вспомогательными методами
public static class Utils
{
    // Обобщённый метод для обмена значений двух переменных
    public static void Swap<T>(ref T a, ref T b)
    {
        // Временная переменная для хранения значения
        T temp = a;
        
        // Меняем местами
        a = b;
        b = temp;
    }

    // Метод для вывода коллекции (массив, список и т.д.)
    public static void PrintCollection<T>(IEnumerable<T> collection)
    {
        // Перебираем все элементы
        foreach (var item in collection)
        {
            // Выводим каждый элемент
            Console.WriteLine(item);
        }
    }
}
