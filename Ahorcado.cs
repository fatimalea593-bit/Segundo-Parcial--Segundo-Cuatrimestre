using System;
using System.Linq;

namespace Ahorcado;

public static class Program
{
    public static void Main()
    {

        // Arreglo con palabras para el juego
        string[] palabrasSecretas = { "PROGRAMACION", "ARREGLO", "CONSOLA", "C_SHARP", "LOGICA" };
        Random random = new Random();

        // Seleccionar palabra aleatoria del arreglo
        string palabraSecreta = palabrasSecretas[random.Next(0, palabrasSecretas.Length)];

        // Arreglos para controlar progreso y letras usadas
        char[] letrasAdivinadas = new char[palabraSecreta.Length];
        string letrasUsadas = "";
        int intentosMaximos = 6;
        int intentosRestantes = intentosMaximos;
        bool juegoGanado = false;

        // Inicializar arreglo de letras adivinadas con guiones bajos
        for (int i = 0; i < letrasAdivinadas.Length; i++)
        {
            letrasAdivinadas[i] = '_';
        }

        Console.WriteLine("=== ¡JUEGO DEL AHORCADO! ===");
        Console.WriteLine($"Palabra: {string.Join(" ", letrasAdivinadas)}");
        Console.WriteLine($"Intentos restantes: {intentosRestantes}\n");

        while (intentosRestantes > 0 && !juegoGanado)
        {
            // Pedir letra al usuario
            Console.Write("Ingresa una letra: ");
            char letraIngresada = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            // Validar si la letra ya fue usada
            if (letrasUsadas.Contains(letraIngresada))
            {
                Console.WriteLine($"Ya usaste la letra '{letraIngresada}'. Intenta con otra.\n");
                continue;
            }

            letrasUsadas += letraIngresada + " ";
            bool letraCorrecta = false;

            // Verificar si la letra está en la palabra secreta (arreglo)
            for (int i = 0; i < palabraSecreta.Length; i++)
            {
                if (palabraSecreta[i] == letraIngresada)
                {
                    letrasAdivinadas[i] = letraIngresada;
                    letraCorrecta = true;
                }
            }

            // Actualizar estado del juego
            if (!letraCorrecta)
            {
                intentosRestantes--;
                Console.WriteLine($"Letra incorrecta. Intentos restantes: {intentosRestantes}");
            }
            else
            {
                Console.WriteLine("¡Letra correcta!");
            }

            // Mostrar progreso
            Console.WriteLine($"Palabra: {string.Join(" ", letrasAdivinadas)}");
            Console.WriteLine($"Letras usadas: {letrasUsadas}\n");

            // Comprobar si se ganó
            if (!string.Join("", letrasAdivinadas).Contains('_'))
            {
                juegoGanado = true;
            }
        }

        // Mostrar resultado final
        if (juegoGanado)
        {
            Console.WriteLine($"¡FELICIDADES! Adivinaste la palabra: {palabraSecreta}");
        }
        else
        {
            Console.WriteLine($"¡PERDISTE! La palabra secreta era: {palabraSecreta}");
        }
    }
}


