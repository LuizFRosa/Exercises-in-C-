using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o preco do Produto desejado :");
        string entradaPreco = Console.ReadLine();
        double preco = Convert.ToDouble(entradaPreco);

        Console.WriteLine("Digite o desconto deste produto:");
        string entradadesconto = Console.ReadLine();
        double desconto = Convert.ToDouble(entradadesconto);
  
        double produto = (preco* desconto)/100;
        
        Console.WriteLine("o valor do seu produto com desconto é : "+produto);

        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}
