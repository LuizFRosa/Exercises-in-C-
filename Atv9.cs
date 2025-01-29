using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra");
        string palavra = Console.ReadLine();

        Console.WriteLine("Esta palavra possui : " + palavra.Length + " Letras.");
        
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}
