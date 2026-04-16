// Простой класс "Человек"
public class Person
{
    //имя
    public string Name { get; set; }
    //возраст
    public int Age { get; set; }

    // Переопределение метода ToString для красивого вывода
    public override string ToString()
    {
        return $"{Name}, {Age}";
    }
}
