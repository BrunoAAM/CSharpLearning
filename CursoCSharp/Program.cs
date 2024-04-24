using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;

namespace CursoCSharp
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencias - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternarios - Fundamentos", OperadoresTernarios.Executar},
                //Estrutura de controle
                {"Estrutura if - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura if/else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura if/else/if - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle", EstrutuaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},
                //Classes e Métodos
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Metodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desagio Atributos - Classes e Metodos", DesafioAtributos.Executar},
                {"Params - Classes e Metodos", Params.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"Getter e Setters - Classes e Metodos", GetSet.Executar},
                {"Props - Classes e Metodos", Props.Executar},
                {"ReadOnly - Classes e Metodos", ReadOnly.Executar},
                {"Enum - Classes e Metodos", EnumExemplo.Executar},
                {"Struct - Classes e Metodos", ExemploStruct.Executar},
                { "Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar},
                { "Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                { "Parâmetros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                { "Parâmetro com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar},

                // Coleções
                { "Array - Coleções", Colecoes.Array.Executar},
                { "List - Coleções", ColecoesList.Executar},
                { "Array List - Coleções", ColecoesArrayList.Executar},
                { "Set - Coleções", ColecoesSet.Executar},
                { "Queue - Coleções", ColecoesQueue.Executar},
                { "Igualdade - Coleções", Igualdade.Executar},
                { "Stack - Coleções", ColecoesStack.Executar},
                { "Dictionary - Coleções", ColecoesDictionary.Executar},

                // OO
                { "Herança - OO", Heranca.Executar},
                { "Construtor This - OO", ConstrutorThis.Executar},
                { "Encapsulamento - OO", OO.Encapsulamento.Executar},
                { "Polimorfismo - OO", Polomorfismo.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}