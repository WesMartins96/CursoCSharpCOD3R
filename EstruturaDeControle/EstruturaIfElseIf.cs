using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharpCOD3R.EstruturaDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a sua nota: ");

            string entrada = Console.ReadLine();
            double.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine($"Nota: {nota.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aulo Destaque!");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine($"Nota: {nota.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aprovado!");
            }
            else if (nota >= 5.0)
            {
                Console.WriteLine($"Nota: {nota.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("De Recuperação!");
            }
            else
            {
                Console.WriteLine($"Nota: {nota.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Reprovado!");
            }

            Console.WriteLine("Fim!");
        }
    }
}
