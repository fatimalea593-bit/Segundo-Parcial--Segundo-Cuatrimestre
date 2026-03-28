using System;
using System.Linq;
using System.Collections.Generic;


namespace Sábado_28;

public static class Program
{
    public static void Main()
    {



        Random rd = new Random();
        List<string> lista1 = new List<string>();
        List<string> lista2 = new List<string>();
        List<string> lista3 = new List<string>();

        // 1. Generar cantidades (Suman 100)
        int n1 = rd.Next(1, 80);
        int n2 = rd.Next(1, 100 - n1);
        int n3 = 100 - (n1 + n2);

        // 2. Llenar listas con ESTRELLAS (Cambié los colores aquí)
        for (int i = 0; i < n1; i++)
        {
            lista1.Add("⭐"); // Amarillo
        }
        for (int i = 0; i < n2; i++)
        {
            lista2.Add("🧡"); // Naranja
        }
        for (int i = 0; i < n3; i++)
        {
            lista3.Add("💜"); // Morado
        }

        // 3. Totales
        Console.WriteLine("Grupo 1: " + n1 + " | Grupo 2: " + n2 + " | Grupo 3: " + n3);
        Console.WriteLine("Total: " + (n1 + n2 + n3) + "\n");

        // 4. IMPRESIÓN HORIZONTAL
        Console.WriteLine("--- HORIZONTAL ---");
        for (int i = 0; i < lista1.Count; i++)
        {
            Console.Write(lista1[i] + " ");
        }
        for (int i = 0; i < lista2.Count; i++)
        {
            Console.Write(lista2[i] + " ");
        }
        for (int i = 0; i < lista3.Count; i++)
        {
            Console.Write(lista3[i] + " ");
        }

        // 5. IMPRESIÓN VERTICAL
        Console.WriteLine("\n\n--- VERTICAL ---");
        for (int i = 0; i < lista1.Count; i++)
        {
            Console.WriteLine(lista1[i]);
        }
        for (int i = 0; i < lista2.Count; i++)
        {
            Console.WriteLine(lista2[i]);
        }
        for (int i = 0; i < lista3.Count; i++)
        {
            Console.WriteLine(lista3[i]);
        }

        Console.ReadKey();
    }
}

