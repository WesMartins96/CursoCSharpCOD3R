using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharpCOD3R.EstruturaDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            //Estrutura de controle if(expressão) sempre retornará um bool.
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a sua nota: ");
            entrada = Console.ReadLine();
            //Para usar o CultureInfo.InvariantCulture(usar o . em vez da ,) 
            //temos que adicionar NumberStyles.Any, CultureInfo.InvariantCulture, dentro do Try.Parse()
            double.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out double nota);

            Console.WriteLine("Possui bom comportamento?: (S/N) ");
            entrada = Console.ReadLine();
            if (entrada == "S" || entrada == "s")
                bomComportamento = true;

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de Honra!");
            }
        }
    }
}
