using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            //3 Metodos de interpolação de string
            string nome = "Playstation 5";
            string marca = "Sony";
            double preco = 5.999;

            //Metodo 1
            Console.WriteLine("O " + nome + " da marca " + marca + " custa: " + preco);

            //Metodo 2
            Console.WriteLine("O {0} da marca {1} está na promoção: {2}", nome, marca, preco);

            //Metodo 3
            Console.WriteLine($"O {nome} da marca {marca} está custando: {preco}");
        }
    }
}
