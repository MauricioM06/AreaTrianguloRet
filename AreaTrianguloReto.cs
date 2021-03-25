using System;

namespace Triângulo
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			double Base;
			double Altura;
			double Area;
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Área do Triângulo Reto");
			Console.WriteLine();
			Console.ResetColor();
			
			Console.Write("Insira a base: ");
			Base = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Insira a altura: ");
			Altura = Convert.ToDouble(Console.ReadLine());
			
			Area = Base * Altura / 2;
			
			Console.WriteLine();
			Console.WriteLine("Área: " + Area);
        }
    }
}