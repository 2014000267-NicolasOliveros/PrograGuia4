using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer numero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());

        int menor = Math.Min(num1, num2);
        int mayor = Math.Max(num1, num2);
        int suma = 0;

        for (int i = menor; i <= mayor; i++)
        {
            suma += i;
        }

        Console.WriteLine("La suma es: " + suma);
    }
}