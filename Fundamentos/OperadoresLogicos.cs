using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            // AND && -> os dois precisam ser True
            var comprouTV50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine($"Comprou a TV 50'SAMSUNG 4K? {comprouTV50}");

            // OR || -> Apenas um precisa ser true
            var comprouPs5 = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"Comprou o Playstation 5 Special Edition? {comprouPs5}");

            // XOR ^ -> Apenas um pode ser true
            var casaNaPraia = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine($"Comprou a Casa na praia? {casaNaPraia}");

            // Negação Lógica ! -> se é true vira false, se for false vira true
            Console.WriteLine($"Comprou a Casa na praia? {!casaNaPraia}");

        }
    }
}
