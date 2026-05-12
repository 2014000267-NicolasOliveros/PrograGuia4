using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un numero: ");
        int num = int.Parse(Console.ReadLine());

        int i = 21;

        do
        {
            Console.WriteLine(i);
            i += 2;

        } while (i <= num);
    }
}