using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.ClassesEMetodos
{
    class Carro
    {
        //Atributos da classe usam PascalCase (começam com letra maiúscula)
        public string Modelo;
        public string Fabricante;
        public int Ano;


        //criando um construtor com paramêtros, usam camelCase (começam com letra minuscúla)
        public Carro(string modelo, string fabricante, int ano)
        {
            //pegamos o valor do paramêtro deste construtor e atribuimos ao atributo da classe
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        //Construtor padrão para não dar erro, pois criamos um acima e com isso da erro no construtor padrão.
        public Carro()
        {

        }
    }

    class Construtores
    {
        public static void Executar()
        {
                            //Este é o construtor padrão
            Carro carro = new Carro();
            carro.Fabricante = "Ford";
            carro.Modelo = "Fiesta Supercharge";
            carro.Ano = 2005;
            Console.WriteLine($"{carro.Fabricante}, {carro.Modelo}, {carro.Ano}");


                            //Construtor que recebe 3 paramêtros de entrada
            var carro2 = new Carro("Eclipse", "Mitsubishi", 1998);
            Console.WriteLine($"{carro2.Fabricante}, {carro2.Modelo}, {carro2.Ano}");


            //Mais uma forma de criar com construtor padrão
            var carro3 = new Carro()
            {
                Fabricante = "BMW",
                Modelo = "X4",
                Ano = 2020
            };
            Console.WriteLine($"{carro3.Fabricante}, {carro3.Modelo}, {carro3.Ano}");
        }
    }
}
