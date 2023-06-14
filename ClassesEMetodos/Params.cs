using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.ClassesEMetodos
{
    class Params
    {
        //Criei um método static chamado Recepcionar para podermos usa-la dentro da classe Executar que também é static, assim sem a necessidade de instanciar.


        
        // Params é uma estrutura que agrupa varios parametros dentro dela, no exemplo abaixo temos 5 parametros como exemplo.
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Olá {pessoa}");
            }

        }


        public static void Executar()
        {
            //Parametros Variaveis
            Recepcionar("Wesley", "Beatriz", "Gael", "Cloud", "Tifa");
        }
    }
}
