using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharpCOD3R.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            //Veremos como formatar números, pega sempre a linguagem padrão da maquina.
            double valor = 15.175;
                                            //F1 -> Uma unica casa decimal, arredondando o valor.
            Console.WriteLine(valor.ToString("F1"));

                                            //C -> Currency, transforma o valor em moeda, arredondando o valor.
            Console.WriteLine(valor.ToString("C"));

                                            //P -> Percentual, ele pega o valor multiplica por 100.
            Console.WriteLine(valor.ToString("P"));

                                            //#.## -> Valores customizados, usando #, e arredonda o valor.
            Console.WriteLine(valor.ToString("#.##"));


            //Mudar o valor para outra lingua.
            CultureInfo culture = new CultureInfo("en-US");
                                            //C2 -> Moeda com duas casas decimais.
            Console.WriteLine(valor.ToString("C2", culture));


            //Colocando zeros a esquerda de um numero
            int numeros = 256;
                                           //D10 -> Coloca zeros da posição 0 do index até a ultima que tenha um numero, neste exemplo: 0000000256
            Console.WriteLine(numeros.ToString("D10")); //0000000 + 256  => D10 7 zeros + 3 numeros;


        }
    }
}
