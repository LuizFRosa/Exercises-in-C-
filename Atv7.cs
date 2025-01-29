using System;

class Program
{
    static void Main()
    {
            Console.WriteLine("Digite o seu nome:");
        string nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade:");
        int idade;

        if (int.TryParse(Console.ReadLine(), out idade))
        {  
            Console.WriteLine("Oi, Tudo Bem "+nome+ "?! Você tem "+idade+  " anos correto?");
        }
        else
        { 
            Console.WriteLine("Idade inválida. Insira uma idade que seja válida.");
        }
            Console.WriteLine("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();
    }
}
