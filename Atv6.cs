using System;
	
	class program 
{
	static void Main ()
	{ 
		Console.WriteLine("Escolha um numero decimal");
		decimal numero = decimal.Parse(Console.ReadLine());
    
		Console.Write("O número escolhido  foi " +numero);
	  Console.Write(Console.ReadLine());
	  Console.WriteLine("Pressione qualquer tecla para encerrar...");
		Console.ReadKey();
 
	} 
}
