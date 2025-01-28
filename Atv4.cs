using System;

namespace Exercicios_em_C_
{
	class Program
	{
		public static void Main()
		{
			
            Console.Write("Você gosta de Garotas? (sim/nao) ");
            string resposta = Console.ReadLine().ToLower(); 
            
            bool respostaBool;
            
            if (resposta == "sim")
            {
                respostaBool = true; 
                Console.WriteLine("Sonic Concorda com sua opinião... :D");
            }
            else if (resposta == "nao")
            {
                respostaBool = false;
                Console.WriteLine("Sonic Discorda de sua opinião!! ,-,");
            }
            else
            {

                Console.WriteLine("Resposta inválida! Sonic me diga é 'sim' ou 'nao'.");
                return; 
            }
            
            Console.WriteLine("Sua resposta foi: " + respostaBool);
           
            Console.ReadKey();
        }
    }
}
