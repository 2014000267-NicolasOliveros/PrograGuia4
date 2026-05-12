using System;

class Program
{
    static void Main()
    {
        int monedas;

        do
        {
            Console.Write("Ingrese la cantidad de monedas del jugador: ");
            monedas = int.Parse(Console.ReadLine());

            if (monedas < 350)
            {
                Console.WriteLine("Nivel 5 bloqueado. Necesitas al menos 350 monedas.");
            }

        } while (monedas < 350);

        Console.WriteLine("Felicidades! Has desbloqueado el Nivel 5.");
    }
}