using PruebaTecnica.MediaCalculadora;
using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese los números separados por comas (por ejemplo, 1,2,3,4,5):");
        string input = Console.ReadLine();
        List<double> numbers = ParseInput(input);
        var context = new MediaCalculatorContext();

        // Seleccionar el agente dinámicamente
        context.SetMediaCalculator(new AAgent());
        var resultA = context.CalculateMedia(numbers);
        Console.WriteLine("Media A: " + resultA);

        context.SetMediaCalculator(new BAgent());
        var resultB = context.CalculateMedia(numbers);
        Console.WriteLine("Media B: " + resultB);
        

        context.SetMediaCalculator(new CAgenteMedian());
        var resultC = context.CalculateMedia(numbers);
        Console.WriteLine("Media C: " + resultC);
        ////
        Console.ReadLine();
    }
    static List<double> ParseInput(string input)
    {
        List<double> numbers = new List<double>();

        string[] parts = input.Split(',');

        foreach (string part in parts)
        {
            if (double.TryParse(part, out double number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine($"Error al analizar: '{part}'. No es un número válido.");
                return new List<double>(); // Devuelve una lista vacía si hay algún error
            }
        }

        return numbers;
    }
}

