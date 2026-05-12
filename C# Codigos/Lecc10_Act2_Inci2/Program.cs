using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un numero: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 2; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}