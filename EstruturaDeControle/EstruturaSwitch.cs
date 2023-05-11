using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.EstruturaDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            //Estrutura switch criada expecificamente para multiplas seleções.

            Console.Write("Avalie o meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                    Console.WriteLine("Ruim");
                    break;
                case 2:
                    Console.WriteLine("Regular");
                    break;
                case 3:
                    Console.WriteLine("Bom");
                    break;
                case 4:
                    Console.WriteLine("Legal");
                    break;
                case 5:
                    Console.WriteLine("ótimo");
                    break;
                default:
                    Console.WriteLine("Digite uma avaliação valida [1 a 5]");
                    break;
            }
            Console.WriteLine("Obrigado por responder!");
            Console.WriteLine("Fim!");
        }
    }
}
