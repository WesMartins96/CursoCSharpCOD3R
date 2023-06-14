using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.ClassesEMetodos
{
    class DesafioAtributo
    {

        //RESPOSTA: Atributo pertence a instância, parar termos acesso temos que instanciar.
        int a = 10;

        public static void Executar()
        {
            //DESAFIO: Acesse a variável 'a' dentro do método executar e imprima no console seu valor.

            //RESOLUÇÃO ABAIXO:
            var desafio = new DesafioAtributo();
            Console.WriteLine($"Valor de a: {desafio.a}");
        }
    }
}
