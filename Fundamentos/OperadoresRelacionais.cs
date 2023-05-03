using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharpCOD3R.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //O Resultado de uma operação relacional sempre retorna um bool (True ou False)

            Console.WriteLine("Digite a sua nota: EX: 6.0");
            double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Para funcionar o "." exemplos: 6.0, 7.0, 1.0
            double notaDeCorte = 7.0;

            Console.WriteLine($"Nota inválida? {nota > 10.0}");
            Console.WriteLine($"Nota inválida? {nota < 0.0}");
            Console.WriteLine($"Perfeito? {nota == 10}");
            Console.WriteLine($"Tem como melhorar? {nota != 10.0}");
            Console.WriteLine($"Passou por média? {nota >= notaDeCorte}");
            Console.WriteLine($"Recuperação? {nota < notaDeCorte}");
            Console.WriteLine($"Reprovado? {nota <= 3.0}");

        }
    }
}
