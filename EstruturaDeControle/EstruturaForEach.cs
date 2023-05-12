using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.EstruturaDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            //ForEach traz um modo de percorrer os elementos com uma estrutura mais simples que o for por exemplo.

            //Exemplo para percorrer cada letra de uma palavra com foreach
            var palavra = "Opa!";
            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }


            //Percorrendo um array
            var alunos = new string[] { "Wesley", "Gael", "Beatriz" };
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
