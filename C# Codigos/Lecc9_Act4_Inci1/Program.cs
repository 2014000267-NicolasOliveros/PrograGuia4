using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un numero: ");
        int num = int.Parse(Console.ReadLine());

        int i = 1;

        do
        {
            int resultado = num * i;
            Console.WriteLine($"{num} x {i} = {resultado}");
            i++;

        } while (i <= 10);
    }
}