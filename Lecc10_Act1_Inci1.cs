
internal class Program
{
    private static void Main(string[] args)
    {
        const int tot_sellos = 8;
        Console.WriteLine("----BIENVENIDOS A LA BARBERÍA DE CRUP----");
        for (int i = 0; i < tot_sellos; i++)
        {

            Console.WriteLine("\nSello Actual {0} de {1}", i, tot_sellos);
            Console.WriteLine("Presione cualquier tecla para registrar un sello");
            Console.ReadKey();

            Console.WriteLine(">>Sellos #{0} registrados correctamente", i);
        }
        Console.WriteLine("\n*************************************");
        Console.WriteLine("¡CUPONERA COMPLETA!");
        Console.WriteLine("Orozco, has ganado tu corte de cabello GRATIS");
        Console.WriteLine("\n*************************************");

        Console.WriteLine("\nPresione una tecla para cerrar...");
        Console.ReadKey();
    }
}