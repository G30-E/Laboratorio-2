using System;

class Program
{
    static void Main(string[] args)
    {
      
        Console.WriteLine("Ingresa el primer valor numérico:");
        double valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo valor numérico:");
        double valor2 = double.Parse(Console.ReadLine());
      
        Console.WriteLine("\nResultados de las comparaciones:");

        Console.WriteLine($"¿El primer valor ({valor1}) es mayor que el segundo valor ({valor2})? {valor1 > valor2}");

        Console.WriteLine($"¿El primer valor ({valor1}) es menor que el segundo valor ({valor2})? {valor1 < valor2}");

        Console.WriteLine($"¿El primer valor ({valor1}) es igual al segundo valor ({valor2})? {valor1 == valor2}");

        bool andComparacion = valor1 > 0 && valor2 < 100;
        Console.WriteLine($"¿El primer valor es mayor que 0 y el segundo valor es menor que 100? {andComparacion}");

        bool orComparacion = valor1 == valor2 || valor1 < 50;
        Console.WriteLine($"¿El primer valor es igual al segundo o el primer valor es menor que 50? {orComparacion}");
    }
}
