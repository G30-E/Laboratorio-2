using System;

class Program
{
    static void Main(string[] args)
    {
        double numeroDecimal;
        string texto;
        bool valorBooleano;


        Console.Write("Ingresa un número entero: ");
        int numeroEntero = int.Parse(Console.ReadLine());

        Console.Write("Ingresa un número decimal: ");
        numeroDecimal = double.Parse(Console.ReadLine());

        Console.Write("Ingresa un texto: ");
        texto = Console.ReadLine();

        Console.Write("Ingresa un valor verdadero o falso (true/false): ");
        valorBooleano = bool.Parse(Console.ReadLine());

        
        Console.WriteLine("\nValores ingresados:");
        Console.WriteLine("EL número entero ingresado es: " + numeroEntero);
        Console.WriteLine("El número decimal ingresado es: " + numeroDecimal);
        Console.WriteLine("El texto ingresado es: " + texto);
        Console.WriteLine("El valor booleano ingresado es: " + valorBooleano);
    }
}
