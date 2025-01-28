using System;

namespace Exercicios_em_C_
{
	class Program
	{
		public static void Main()
		{
			Console.Write("Digite um número: ");
			string input = Console.ReadLine();
			float numero;
			
			if (float.TryParse(input, out numero))
			{
				Console.WriteLine("O número digitado foi o: " + numero);
			}
			else
			{
				Console.WriteLine("Entrada Invalida, Digite um numero...");
			
			}
				Console.WriteLine("Aperte qualquer botão para Encerrar :D!");
				Console.ReadKey();
		}
	}
}
