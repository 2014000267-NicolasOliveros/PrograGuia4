using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un numero entero: ");
        int num = int.Parse(Console.ReadLine());

        int factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("El factorial es: " + factorial);
    }
}