

using Arreglos.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nArreglos");

        MiArreglo oMiArreglo = new MiArreglo(20);
        oMiArreglo.Llenar(5, 20);
        

        Console.WriteLine("\nArreglo desordenado");
        Console.WriteLine(oMiArreglo);


        Console.WriteLine("\nArreglo ordenado ascendente");
        oMiArreglo.Ordenar();
        Console.WriteLine(oMiArreglo);

        Console.WriteLine("\nArreglo ordenado desascendente");
        oMiArreglo.Ordenar(false);
        Console.WriteLine(oMiArreglo);

        Console.ReadKey();
    }
}