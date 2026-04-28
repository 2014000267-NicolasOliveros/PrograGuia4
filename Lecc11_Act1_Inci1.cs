internal class Program
{
    private static void Main(string[] args)
    {
        int cajones = 0;
        const int capacidad = 10;
        string opcion;

        Console.WriteLine("====CONTROL DE ACCESO AL CENTRO COMERCIAL====");

        do
        {
            Console.WriteLine("\nEstado: {0} ocupados | {1} disponibles",
                cajones, capacidad - cajones);
            Console.WriteLine("Ingresar un nuevo vehiculo? (S/N)");
            opcion=Console.ReadLine().ToUpper();

            if (opcion=="S")
            {
                cajones++;
                Console.WriteLine(">>Acceso concedido, levantando Talanquera...");
            }
            else if (opcion!="N")
            {
                Console.WriteLine(">>Opcion Invalida. Use 'S' Para Si o la 'N' Para No");
            }
        }
        while (opcion!="N" && cajones<capacidad);
        if (cajones>=capacidad)
        {
            Console.WriteLine("\n**************************");
            Console.WriteLine("ALERTA: Estacionamiento lleno");
            Console.WriteLine("\n**************************");
        }
        Console.WriteLine("Apagando el sistema de control.");
        Console.WriteLine("Presione una tecla para continuar");
        Console.ReadKey();
    }
}