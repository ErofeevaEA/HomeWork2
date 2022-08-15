using System;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Введите число = ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > -100 && n < 100)
        {
            Console.WriteLine("Третьей цифры нет");
        }

        else
        {
            if (n < 0)
            {
                n = -1 * n;
            }
            string a = Convert.ToString(n);
            Console.WriteLine("Третье число число: " + a[2]);
        }

    }

}
