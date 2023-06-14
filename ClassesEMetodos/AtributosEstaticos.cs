using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.ClassesEMetodos
{

    public class Produto
    {
        public string Nome;
        public double Preco;
        //Atributo estático
        public static double Desconto = 0.1;


        //Construtores
        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }


    }


    class AtributosEstaticos
    {
        public static void Executar()
        {

            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
            };

            //Como agora o atributo é static, ao colocar sem instanciar ele adiciona o desconto a todos os produto.
            Produto.Desconto = 0.5; // Desconto de 50%
            Console.WriteLine($"Preço com Desconto: {produto1.CalcularDesconto()}");
            Console.WriteLine($"Preço com Desconto: {produto2.CalcularDesconto()}");



            //Como agora o atributo é static, ao colocar sem instanciar ele adiciona o desconto a todos os produto.
            Produto.Desconto = 0.02; // Desconto de 2%
            Console.WriteLine($"Preço com Desconto: {produto1.CalcularDesconto()}");
            Console.WriteLine($"Preço com Desconto: {produto2.CalcularDesconto()}");



        }
    }
}
