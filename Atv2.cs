using System;

namespace Exercicios_em_C_
{
	class Program
	{
		public static void Main()
		{
			Console.Write("Digite um número real: ");
			double numero = double.Parse(Console.ReadLine());
			Console.WriteLine("O número digitado foi o: " + numero);
			Console.WriteLine(Console.ReadLine());
		}
	}
}
