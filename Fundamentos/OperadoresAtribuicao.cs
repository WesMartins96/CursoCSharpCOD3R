using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            //Vamos verificar mais sobre atribuições
            //Atribuição literal
            var num1 = 3;

            //Atribuição que substitui o valor da variavel antes declarada.
            num1 = 7;

            //Atribuição aditiva
            num1 += 10; // num1 = num1 + 10;

            //Atribuição subtrativa
            num1 -= 3; // num1 = num - 3;

            //Atribuição multiplicativa
            num1 *= 2; // num1 = num1 * 2;

            //Atribuição Divisiva
            num1 /= 2; // num1 = num1 / 2;

            Console.WriteLine(num1);


            //Atribuição com operadores unários
            int a = 1;
            int b = a;

            a++; // a = a + 1;
            b--; // b = b - 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
