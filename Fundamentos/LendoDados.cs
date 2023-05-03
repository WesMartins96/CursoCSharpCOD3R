using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            //Como ler os dados do console
            Console.WriteLine("Digite aqui o seu Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite aqui a Sua Idade");
            int idade = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Bem Vindo {nome}");
            Console.WriteLine($"Sua idade é {idade}");
            Console.WriteLine($"Agora você é o admin do programa");
            
        }
    }
}
