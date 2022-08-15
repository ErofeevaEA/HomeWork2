using System;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Введите цифру обозначающую день недели: ");
        Console.WriteLine("1 - Пн, 2 - Вт, 3 - Ср, 4 - Чт,  5 - Пт, 6 - Сб, 7 - Вс ");

        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Выходной? ");
        string[] day = { "нет", "нет", "нет", "нет", "нет", "да", "да" };
        Console.WriteLine(day[number - 1]);

    }

}