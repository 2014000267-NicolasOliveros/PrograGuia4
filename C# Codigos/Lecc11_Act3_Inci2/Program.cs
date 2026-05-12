using System;

class Program
{
    static void Main()
    {
        int suma = 0;
        int num;

        do
        {
            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            if (num != 9)
            {
                suma += num;
            }

        } while (num != 9);

        Console.WriteLine("La suma total es: " + suma);
    }
}