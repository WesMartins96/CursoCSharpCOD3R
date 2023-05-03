using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            //Operador ternário, podemos em uma linha fazer uma verificação boleana, usando a sintaxe abaixo.

            var nota = 7.0;
            var resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine($"Desenvolvedor Wesley Martins, você foi {resultado} para a vaga!");

            //Podemos fazer mais verificações usando ternário
            var bomComportamento = true;
            var resultado2 = nota >= 7.0 && bomComportamento ? "Aprovado com Exito" : "Reprovado";
            Console.WriteLine($"Aluno Wes você foi {resultado2} em nossa instituição!");
        }
    }
}
