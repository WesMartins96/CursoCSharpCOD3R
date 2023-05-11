using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharpCOD3R.EstruturaDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7.0)
            {
                Console.WriteLine($"Nota: {nota.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aprovado");
                Console.WriteLine("Não fez mais que a obrigação...");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
