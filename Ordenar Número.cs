using System;
using System.Linq;

namespace Ordenar_Números;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(" ORDENA 3 NÚMEROS");

        Console.Write("Número 1: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Número 2: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Número 3: ");
        int c = int.Parse(Console.ReadLine());


        if (a < b) { a = a + b; b = a - b; a = a - b; }
        if (a < c) { a = a + c; c = a - c; a = a - c; }


        if (b < c) { b = b + c; c = b - c; b = b - c; }

        Console.WriteLine("\n ORDENADOS DE MAYOR A MENOR:");
        Console.WriteLine("1. " + a);
        Console.WriteLine("2. " + b);
        Console.WriteLine("3. " + c);
    }

}

