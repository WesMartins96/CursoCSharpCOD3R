using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        //Não podemos criar métodos com a mesma assinatura.
        //Mas podemos criar métodos com mais propriedades e com o mesmo nome.
        //Agora temos dois métodos Somar diferenciando um do outro.
        public int Somar(int c, int d, int e)
        {
            return c + d + e;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        
    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();

            //Para diferenciar temos que adicionar no construtor as propriedades
            var somarCom2Propriedades = calculadoraComum.Somar(10, 10);
            var somarCom3Propriedades = calculadoraComum.Somar(10, 10, 10);
            Console.WriteLine(somarCom2Propriedades);
            Console.WriteLine(somarCom3Propriedades);

            var subtrairResult = calculadoraComum.Subtrair(200, 150);
            Console.WriteLine(subtrairResult);

            var multiplicarResult = calculadoraComum.Multiplicar(55, 5);
            Console.WriteLine(multiplicarResult);
        }
    }
}
