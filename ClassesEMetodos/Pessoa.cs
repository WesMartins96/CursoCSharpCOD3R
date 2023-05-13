using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.ClassesEMetodos
{
    class Pessoa
    {
        //A partir de uma classe podemos instanciar o objeto, usando assim seus atributos.
        //Usamos PascalCase, não é obrigatório, porem é recomendavel

        public string Nome; //Valor padrão string = null
        public int Idade; //Valor padrão int = 0


        //Método
        public string Apresentar()
        {
                        //Format() => faz a mesma coisa que o WriteLine, porém em vez de mostrar no console, ele retorna uma string Formatada.
            return string.Format($"Olá!, me chamo {Nome}, tenho {Idade} anos de idade!");
        }

        //Método que se reutiliza do método acima, para mostrar no console a string formatada, Apenas a chamando.
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }


    }
}
