using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            //Para instanciar(criar um novo objeto) uma classe.

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Wesley";
            pessoa.Idade = 26;

            //Método criado para retornar uma string formatada.
            Console.WriteLine($"{pessoa.Apresentar()}");

            //Método criado para mostrar direto no console a string
            pessoa.ApresentarNoConsole();


            var pessoa2 = new Pessoa();
            pessoa2.Nome = "Beatriz";
            pessoa2.Idade = 25;
            pessoa2.ApresentarNoConsole();

            //Mais utilizado é o Apresentar();
            var stringFormatada = pessoa2.Apresentar();

            //Desta forma podemos realizar a manipulação dessa string do modo que quisermos.
            Console.WriteLine(stringFormatada.Length);
            Console.WriteLine(stringFormatada.ToUpper());
        }
    }
}
