using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Linguagem fortemente tipada
            double raio = 4.5;
            raio = 5.5;
            //constante - valor que não pode ser alterado
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é: " + area);

            //Booleano - True ou False
            bool estaChuvendo = true;
            Console.WriteLine(estaChuvendo);


        }
    }
}
