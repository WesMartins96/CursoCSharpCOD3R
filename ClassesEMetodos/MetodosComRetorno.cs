using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.ClassesEMetodos
{
    class CalculadoraComum
    {
              //assinatura do método
        public int Somar(int a, int b)
        {
            return a + b;
        }

        //Não podemos criar métodos com a mesma assinatura.
        //Mas podemos criar métodos com mais propriedades e com o mesmo nome.
        //Agora temos dois métodos Somar diferenciando um do outro.
        public int Somar(int a, int b, int c)
        {
            return a + b + c;
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


    //CalculadoraCadeia que retorna a propria instancia(objeto)
    class CalculadoraCadeia
    {
        //variável interna
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        //Limpar memoria
        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        //Imprimir no console
        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
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



            var calculadoraCadeia = new CalculadoraCadeia();
            //Usando notação ponto para encadear.
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            //Podemos usar de outro modo, com o Resultado();
            var resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);

        }
    }
}
