using PruebaTecnica.Context;
using PruebaTecnica.Interface;
using PruebaTecnica.MediaCalculadora;
using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        try
        {
            ////Punto 1
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

            ///Punto 2    
            Console.WriteLine("Seleccione el tipo de agente (A, B, C):");
            char agentType = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine("\nIngrese el tamaño de la escalera:");
            int n = int.Parse(Console.ReadLine());
            IStaircasePrinter printer = StaircasePrinterFactory.GetStaircasePrinter(agentType);
            string result = printer.PrintStaircase(n);
            Console.WriteLine("\nResultado:");
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nError: " + ex.Message);
        }
       
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

