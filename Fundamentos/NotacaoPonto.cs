using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            //Exemplo notação Ponto
            var saudacao = "Ola".Insert(3, " World!").Replace(" World!", " Mundo!").ToUpper();
            //Usando a notação ponto temos varios exemplos(Funcionalidades) que a propria IDE nos da como no exemplo acima.
            Console.WriteLine(saudacao);
            //Resultado: OLA MUNDO!



        }
    }
}
