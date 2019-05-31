using ERD2.Questao_1;
//using ERD2.Questao_2;
using ERD2.Questao_4;
using ERD2.TADs;
using ERD2.TADs.Implementacoes;
using ERD2.Ordenação.Implementacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERD2
{
    public class Program
    {
        //private static Lista listaDePacientes;

        private static Lista listaDeContatos;

        //atividade 3
        private static Fila Caixa1;
        private static Fila Caixa2;
        private static Fila Caixa3;
        private static Fila Caixa4;
        private static Fila Caixa5;

        //atividade 4
        private static Pilha P1;
        private static Pilha P2;
        private static Pilha P3;

        //atividade 5
        private static Ordenacao ordenacao;

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
        /// Questao 2: 
        /// </summary>
        private static void Questao2()
        {

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
            //exemplo de aleatório
            //Random rnd = new Random();
            //int valorCombustivel = rnd.Next(4, 16);

            Caixa1 = new Fila(1000);
            Caixa2 = new Fila(1000);
            Caixa3 = new Fila(1000);
            Caixa4 = new Fila(1000);
            Caixa5 = new Fila(1000);

            //continuar...
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