﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //Calculo Preço com desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preço total é: {totalComDesconto.ToString("C")}");


            //Calculo IMC
            double peso = 91.2;
            double altura = 1.82;

            //double imc = peso / (altura * altura); pode-se fazer a mesma coisa com o Math.Pow(base, expoente)
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"O IMC é: {imc.ToString("F1")}%");


            //Par ou Impar  (usando o operador módulo %)
            int par = 24;
            int impar = 55;
            Console.WriteLine($"{par}/2 tem resto {par % 2}");
            Console.WriteLine($"{impar}/2 tem resto {impar % 2}");

        }
    }
}
