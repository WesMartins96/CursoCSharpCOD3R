using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.EstruturaDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            //Estrutura For, muito usado para quando queremos executar um determinado número de repetições.

            //Usando o while para percorrer um determinado número de repetições, Abaixo veremos como o for é melhor para fazer isso.
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"O valor de i é: {i}.");
                i++;
            }

            //Abaixo realizamos o básico de uma repetição com um número determinado de vezes com for.
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine($"O valor de x é: {x}.");
            }


            //Calcular a media de uma turma
            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();

            int.TryParse(entrada, out int tamanhoTurma);

            for (int t = 1; t <= tamanhoTurma; t++)
            {
                Console.Write($"Informe a nota do aluno {t}: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            //Ternário = condição ? valor_se_verdadeiro : valor_se_falso
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine($"Média da turma: {media.ToString("F1")}");
        }
    }
}
