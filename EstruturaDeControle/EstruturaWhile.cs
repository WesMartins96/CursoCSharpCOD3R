using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            //Estrutura de repetição WHILE, interesante domina-lo pois é muito usado nos sistemas.
            //Ideal quando não sabemos ao certo quantas repetições será efetuada pelo sistema.
            //Enquanto for true ele não sai do escopo while (Repetição infinita)

            int palpite = 0;

            Random random = new Random();

            int numeroSecreto = random.Next(1, 16); // Número de 1 a 15.

            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Número encontrado em {tentativas} tentativas");
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                }
                else
                {
                    Console.WriteLine("Maior... Tente Novamente");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                }
            }

        }
    }
}
