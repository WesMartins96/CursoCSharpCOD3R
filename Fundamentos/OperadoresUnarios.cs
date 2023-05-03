using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            //Operadores unários em ação.
            Console.WriteLine(-valorNegativo); //Colocando um - nesta variavel -5 ele inverte o sinal, fica positivo. 

            Console.WriteLine(!booleano); //Usando a negação lógica ! ele muda o valor bool setado em true para agora false.

            numero1++;
            Console.WriteLine(numero1); // Incrementa +1 ao valor. 
            //poderiamos passar direto no Console, ++numero1, assim o incremento acontece antes da leitura.

            Console.WriteLine(--numero2); //Colocando -- antes do nome da variavel ele irá retirar 1 e já apresentará no console o resultado.



        }
    }
}
