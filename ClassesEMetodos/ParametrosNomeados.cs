using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.ClassesEMetodos
{
    class ParametrosNomeados
    {

        //Passar paramêtros nomeados podem deixar muito claro a intenção na chamada, para mostrar exatamente quais parâmetros que desejamos passar. 
        public static void Formatar(int dia, int mes, int ano)
        {
            //Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);

            Console.WriteLine($"{dia:D2}/{mes:D2}/{ano}"); //:D2, formata com zero nas datas. o 1 fica 01.
        }

        public static void Executar()
        {
            Formatar(mes: 1, dia: 6, ano: 1996);
        }
    }
}
