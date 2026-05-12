using System;

class Program
{
    static void Main()
    {
        int peso, pesoTot = 0, manTot = 0;

        do
        {
            Console.Write("Digita el peso de una manzana mayor a 180g: ");
            peso = int.Parse(Console.ReadLine());

            if (peso >= 180)
            {
                pesoTot += peso;
            }
            else
            {
                Console.WriteLine("El numero es menor a 180 o es invalido");
            }

            Console.WriteLine("El peso total es de: " + pesoTot);

            manTot++;

            Console.WriteLine("Llevas " + manTot + " manzanas");

        } while (pesoTot < 1000);

        if (pesoTot == 1000)
        {
            Console.WriteLine("Se ha completado el kilo de manzana exacto");
        }
        else
        {
            Console.WriteLine("Se ha excedido el peso de un kilo");
        }
    }
}