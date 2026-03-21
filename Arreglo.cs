using System;
using System.Linq;

namespace Arreglo;

public static class Program
{
    public static void Main()
    {
        int[] arreglo = new int[5];

        Console.WriteLine("Por favor, ingresa 5 números:");


        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Introduce el número para la posición {i}: ");

            arreglo[i] = int.Parse(Console.ReadLine());
        }


        Console.WriteLine("¡Arreglo lleno! Los números son:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Posición {i}: {arreglo[i]}");
        }

    }
}
