using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.ClassesEMetodos
{
    class CalculadoraEstatica
    {
        //Com Método static, podemos acessar a classe sem se fazer necessário instanciar.

        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            //Exemplo de uma classe estatica que não precisa ser instanciada para ser utilizada.
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine($"Resultado: {resultado}");

            resultado = CalculadoraEstatica.Somar(10, 2);
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
