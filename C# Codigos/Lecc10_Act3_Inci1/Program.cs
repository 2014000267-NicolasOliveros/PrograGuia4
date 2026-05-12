using System;

class Program
{
    static void Main()
    {
        int suma = 0;

        for (int num = 1; num <= 22; num++)
        {
            int contador = 0;

            for (int divisor = 1; divisor <= num; divisor++)
            {
                if (num % divisor == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
            {
                suma += num;
            }
        }

        Console.WriteLine("La suma de los numeros primos entre 1 y 22 es: " + suma);
    }
}