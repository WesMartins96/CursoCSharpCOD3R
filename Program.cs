using System;
using System.Collections.Generic;

using CursoCSharpCOD3R.Fundamentos;
using CursoCSharpCOD3R.EstruturaDeControle;
using CursoCSharpCOD3R.ClassesEMetodos;


namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Cometarios.Exercutar },
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar },

                //Estruturas de Controle
                {"Estrutura If - Estrutura de Controle", EstruturaIf.Executar },
                {"Estrutura If Else - Estrutura de Controle", EstruturaIfElse.Executar },
                {"Estrutura If Else If - Estrutura de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar },
                {"Estrutura Do While - Estrutura de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estrutura de Controle", EstruturaForEach.Executar },
                {"Usando Break - Estrutura de Controle", UsandoBreak.Executar },
                {"Usando Continue - Estrutura de Controle", UsandoContinue.Executar },

                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar },
                {"Métodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar },
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar },
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar },

            });

            central.SelecionarEExecutar();
        }
    }
}