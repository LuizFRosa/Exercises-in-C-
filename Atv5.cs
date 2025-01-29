using System;
	
	class program 
{
	static void Main ()
	{ 
		Console.WriteLine("Escolha um caractere");
		char numero = char.Parse(Console.ReadLine());
		Console.Write("O Caractere digitado foi " +numero);
    Console.Write(Console.ReadLine());
	  Console.WriteLine("Pressione qualquer tecla para encerrar...");
	  Console.ReadKey();
	}
}
