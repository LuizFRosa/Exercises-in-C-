using System;

class Program
{
    static void Main()
    {
          Console.WriteLine("Por favor insira o número da sua casa:");
        string numeroCasa = Console.ReadLine();

          Console.WriteLine("Digite o nome da sua rua:");
        string rua = Console.ReadLine();

          Console.WriteLine("Digite o nome do seu bairro:");
        string bairro = Console.ReadLine();

          Console.WriteLine("Digite o nome da sua cidade:");
        string cidade = Console.ReadLine();

          Console.WriteLine("Digite qual é o seu estado:");
        string estado = Console.ReadLine();
      
          Console.WriteLine("O seu Endereço completo é: "+rua+", Nº "+numeroCasa+", "+bairro+" "+cidade+", "+estado);
      
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}
