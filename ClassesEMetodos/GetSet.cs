using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.ClassesEMetodos
{

    public class Moto
    {
        // Set, para alterar o valor do atributo.
        // Get, para ler o valor do atributo.
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto( string marca, string modelo, uint cilindrada)
        {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;

            //Podemos realizar um a validação para cilindrada ser apenas valor positivo desta forma:
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto()
        {

        }

        // Get e Set de Marca
        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }


        // Get e Set de Modelo
        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }


        // Get e Set de Cilindrada
        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        {
            //Cilindradas não podem ser valores negativos, sendo assim faremos uma validação
            //if (cilindrada > 0)
            //{
            //    Cilindrada = cilindrada;
            //}

            //Outro exemplo
            Cilindrada = cilindrada; //usando o tipo uint, desta forma em código fica impossivel setar um valor negativo.
        }
    }

    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());


            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);

            Console.WriteLine($"{moto2.GetMarca()} {moto2.GetModelo()} {moto2.GetCilindrada()}");
         

        }
    }
}
