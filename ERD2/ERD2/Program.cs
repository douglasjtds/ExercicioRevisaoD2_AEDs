﻿using ERD2.Questao_1;
using ERD2.TADs;
using ERD2.TADs.Implementacoes;
using ERD2.Ordenação.Implementacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ERD2.Questao_2;

namespace ERD2
{
    public class Program
    {

        //Questão 1
        private static Lista listaDeContatos;

        //Questão 2
        private static Fila estacionamento;

        //Questão 3


        static void Main(string[] args)
        {
            #region [Escolha a Questao que deseja executar]
            int numQuestao;

            do
            {
                Console.Clear();
                Console.WriteLine("------[Avaliação D2]------");
                Console.WriteLine("\n");
                Console.WriteLine("[ 1 ] Questão 1");
                Console.WriteLine("[ 2 ] Questão 2");
                Console.WriteLine("[ 3 ] Questão 3");

                Console.WriteLine("\n");

                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha a Questão que deseja executar: ");
                numQuestao = Int32.Parse(Console.ReadLine());
                switch (numQuestao)
                {
                    case 1:
                        Questao1();
                        break;
                    case 2:
                        Questao2();
                        break;
                    case 3:
                        Questao3();
                        break;

                    default:
                        SaiPrograma();
                        break;
                }

            } while (numQuestao != 0);
            #endregion
        }

        #region Questao 1
        /// <summary>
        /// Questao 1: (5 pontos): Implemente um programa utilizando qualquer TAD para cadastrar os contatos de 
        /// uma lista telefônica.Para cada contato cadastrado, o programa deverá solicitar: nome, telefone e e-mail.
        /// O programa deve permitir imprimir todos os contatos cadastrados.
        /// </summary>
        private static void Questao1()
        {
            listaDeContatos = new Lista(100);

            #region Questao 1 - [Escolha o que deseja executar]
            int funcaoExecutada;

            do
            {
                Console.Clear();
                Console.WriteLine("------[Questão 1]------");
                Console.WriteLine("\n");
                Console.WriteLine("[ 1 ] Cadastrar novo contato");
                Console.WriteLine("[ 2 ] Imprimir todos os contatos");

                Console.WriteLine("\n");

                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha o que deseja executar: ");
                funcaoExecutada = Int32.Parse(Console.ReadLine());
                switch (funcaoExecutada)
                {
                    case 1:
                        IncluirNovoContato();
                        break;

                    case 2:
                        ImprimirTodosOsContatos();
                        break;

                    default:
                        SaiPrograma();
                        break;
                }

            } while (funcaoExecutada != 0);
            #endregion
        }

        private static void IncluirNovoContato()
        {
            Console.Clear();
            Console.Write("[Novo Contato]");
            Console.WriteLine("\n");

            var contato = new Contato();

            Console.WriteLine("Entre com os dados do novo contato a ser adicionado na lista...");
            Thread.Sleep(500);

            Console.Write("Nome: ");
            contato.Nome = Console.ReadLine();

            Console.Write("Telefone: ");
            contato.Telefone = Int32.Parse(Console.ReadLine());

            Console.Write("E-mail: ");
            contato.Email = Console.ReadLine();

            listaDeContatos.Insere(contato);

            Console.WriteLine("O contato {0} foi inserido com sucesso.", contato.Nome);
        }

        private static void ImprimirTodosOsContatos()
        {
            //while (!listaDeContatos.IsListaVazia())
            listaDeContatos.Imprime();
        }

        #endregion

        #region Questao 2
        /// <summary>
        /// Questao 2: (7,5 pontos): Manoel percebeu que seu estacionamento com uma entrada era um fiasco. 
        /// Ele resolveu vender o seu terreno e comprar um novo que possui uma entrada e uma saída no fundo do terreno.
        /// Quando chega um novo carro, este é estacionado no terreno de Manoel, um atrás do outro. Quando um carro 
        /// precisa sair, os carros do terreno são retirados pela saída, dão uma volta na quadra e são colocados no 
        /// final da fila pela entrada do estacionamento. Faça um sistema que inclua carros no estacionamento 
        /// informando o número da placa e retire carros usando o identificador(placa). Depois de ter informado a         /// placa, cada vez que é pressionada a tecla S deve ser mostrado o estado do estacionamento.
        /// </summary>
        private static void Questao2()
        {
            estacionamento = new Fila(100);

            #region Questão 2 - [Escolha o que deseja executar]
            int funcaoExecutada;

            do
            {
                Console.Clear();
                Console.WriteLine("------[Questão 2]------");
                Console.WriteLine("\n");
                Console.WriteLine("[ 1 ] Adicionar carro no estacionamento");
                Console.WriteLine("[ 2 ] Retirar carro do estacionamento");
                Console.WriteLine("[ 3 ] Ver o estado do estacionamento");

                Console.WriteLine("\n");

                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha o que deseja executar: ");
                funcaoExecutada = Int32.Parse(Console.ReadLine());
                switch (funcaoExecutada)
                {
                    case 1:
                        IncluirNovoCarro();
                        break;

                    case 2:
                        RetirarCarroDoEstacionamento();
                        break;

                    case 3:
                        //VerEstadoDoEstacionamento();
                        break;

                    default:
                        SaiPrograma();
                        break;
                }

            } while (funcaoExecutada != 0);
            #endregion
        }

        private static void IncluirNovoCarro()
        {
            Console.Clear();
            Console.Write("[Novo Carro]");
            Console.WriteLine("\n");

            var carro = new Carro();

            Console.WriteLine("Entre com os dados do novo carro a ser adicionado na fila...");
            Thread.Sleep(500);

            Console.Write("Insira a placa do novo carro: ");
            carro.Placa = Console.ReadLine();


            estacionamento.Enfileira(carro);

            Console.WriteLine("O carro de placa {0} foi inserido no estacionamento.", carro.Placa);
        }

        private static void RetirarCarroDoEstacionamento()
        {
            Console.Clear();
            Console.Write("[Remover um carro do estacionamento]");
            Console.WriteLine("\n");
            
            var carroRetirado = (Carro)estacionamento.Desenfileira();

            Console.WriteLine("O carro de placa {0} foi removido do estacionamento.", carroRetirado.Placa);
            Thread.Sleep(3000);
        }

        #endregion

        #region Questao 3
        /// <summary>
        /// Questao 3: Uma agência bancária estatal está sofrendo com o mau atendimento aos clientes. Suas filas são gigantescas! O gerente decidiu contratá-lo para que você 
        /// crie uma simulação do atendimento da agência e permita que ele faça experimentos para melhorar o atendimento.
        /// O gerente vai informar a quantidade de minutos que ele deseja executar a simulação. Na agência existem 5 caixas. A cada minuto chegam de 4 a 16 clientes.
        /// Cada caixa atende de 1 a 2 clientes por minuto. Sempre o cliente dá preferência para alguma caixa vazia ou para uma fila com menor número de clientes. 
        /// Para cada cliente que entra na fila deve-se registrar o momento (tempo) que ele entrou na fila. Quando o cliente for atendido deve-se computar a 
        /// diferença entre o tempo atual e o tempo de entrada na fila. Este dado vai servir para calcular o tempo médio dos clientes na fila.
        /// O programa deve informar, por minuto, a quantidade de clientes sendo atendidos e esperando na fila para cada caixa. No término da simulação deve ser 
        /// informado o tempo médio dos clientes aguardando na fila.
        /// </summary>
        private static void Questao3()
        {
            
        }
        #endregion



        #region para fechar o programa

        private static void SaiPrograma()
        {
            Console.WriteLine();
            Console.WriteLine("Você saiu do programa. Clique qualquer tecla para fechar...");
        }
        #endregion
    }
}