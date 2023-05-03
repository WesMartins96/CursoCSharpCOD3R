using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCOD3R.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            //Veremos como funciona as conversões em C#, dependendo de como é feito podemos perder valores(CAST).

            //Conversão bem sucedida, pois o double tem uma maior carga de memória(Capacidade) do que o inteiro
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado); //Conversão implicita


            //Neste caso, não é possivel realizar a conversão implicita, devemos converter explicitamente no código.
            double nota = 9.7;
            int notaTrucada = (int)nota; //usamos o CAST, para realizar a conversão explicita, retirando o valor decimal. (perdendo valor na ação)
            Console.WriteLine(notaTrucada);


            //Conversão de string para numero
            Console.WriteLine("Digite sua idade: ");
            string idadeStr = Console.ReadLine();
            //Para realizar a conversão
            int idadeInt = int.Parse(idadeStr);
            Console.WriteLine($"Idade inserida: {idadeInt}");


            //Usando o Convert
            int idadeConvert = Convert.ToInt32(idadeStr);
            Console.WriteLine($"Idade Convert: {idadeConvert}");


            //Forma mais segura de realizar a conversão STRING to INT (TryParse)
            Console.WriteLine("Digite um numero para o TryParse: ");
            string palavra = Console.ReadLine();
            //realizar o TryParse para a conversão
            int numero;
            int.TryParse(palavra, out numero); //converte a variavel palavra e joga da variavel numero.
            //se não conseguir realizar o a conversão ele retorna Zero
            Console.WriteLine($"Resultado do TryParse: {numero}");

        }
    }
}
