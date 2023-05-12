using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.EstruturaDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar()
        {
            //Estrutura menos usada 
            //Bloco vem antes da espressão while (Fazer / Enquanto)
            //Do While, sempre entrará pelo menos uma vez no escopo, obrigatóriamente.

            string entrada;

            do
            {
                Console.WriteLine("Qual o seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine($"Seja Bem-Vindo {entrada}");

                Console.WriteLine("Deseja Continuar? [S/N]");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}
