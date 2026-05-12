using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un numero entero: ");
        int num = int.Parse(Console.ReadLine());

        int contador = 0;
        int i = 1;

        do
        {
            if (num % i == 0)
            {
                contador++;
            }

            i++;

        } while (i <= num);

        if (contador == 2)
        {
            Console.WriteLine("El numero es primo");
        }
        else
        {
            Console.WriteLine("El numero no es primo");
        }
    }
}