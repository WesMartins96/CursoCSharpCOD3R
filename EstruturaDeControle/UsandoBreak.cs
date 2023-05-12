using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.EstruturaDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            //Exemplo usando o break para forçar uma parada no for;
            Random random = new Random();

            int numero = random.Next(1, 51); // de 1 a 50
            Console.WriteLine($"O número que queremos é {numero}");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine($"{i} é o número que queremos? ");
                if (i == numero)
                {
                    Console.WriteLine("SIM!");
                    //Mesmo achando o numero ele continua percorrendo todo o for.
                    //um modo de forçar a parada assim que entrar no if, seria usando break;
                    break;
                }
                else
                {
                    Console.WriteLine("NÃO!");
                }
            }
            Console.WriteLine("Fim");
        }
    }
}
