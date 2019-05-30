using ERD2.Questao_1;
using ERD2.Questao_2;
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
        private static Lista listaDePacientes;

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
                Console.WriteLine("[ 4 ] Questão 4");
                Console.WriteLine("[ 5 ] Questão 5");
                Console.WriteLine("[ 6 ] Questão 6");

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
                    case 4:
                        Questao4();
                        break;
                    case 5:
                        Questao5();
                        break;
                    case 6:
                        Questao6();
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
        /// Questao 1: Um hospital de cardiologia precisa de um sistema para efetuar o cadastro de pacientes que necessitam
        /// de doação de coração. Para cada paciente que é incluído no sistema deve ser informado o nome, telefone e o grau de
        /// urgência para transplante. O grau de urgência é definido na seguinte escala: (5) Muito urgente; (4) Urgente; (3) Médio;
        /// (2) Pouco urgente; (1) Sem urgência. Sempre que é o hospital recebe um novo coração o sistema é consultado para
        /// obter o próximo paciente que deverá ser operado. O sistema informa o nome e o telefone do paciente. Também a
        /// qualquer momento é possível visualizar o tamanho da fila de espera. Observação: os dados não precisam ser
        /// persistidos em arquivos, podem ficar armazenados somente na memória.
        /// </summary>
        private static void Questao1()
        {
            listaDePacientes = new Lista(100);

            #region Questao 1 - [Escolha o que deseja executar]
            int funcaoExecutada;

            do
            {
                Console.Clear();
                Console.WriteLine("------[Questao 1]------");
                Console.WriteLine("\n");
                Console.WriteLine("[ 1 ] Incluir novo paciente");
                Console.WriteLine("[ 2 ] Novo coração recebido -> consultar próximo paciente para ser operado");
                Console.WriteLine("[ 3 ] Consultar o tamanho da fila de espera");


                Console.WriteLine("\n");

                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha o que deseja executar: ");
                funcaoExecutada = Int32.Parse(Console.ReadLine());
                switch (funcaoExecutada)
                {
                    case 1:
                        IncluirNovoPaciente();
                        break;

                    case 2:
                        NovoCoracao_ConsultarProximoPaciente();
                        break;

                    case 3:
                        ConsultarTamanhoFilaDeEspera();
                        break;

                    default:
                        SaiPrograma();
                        break;
                }

            } while (funcaoExecutada != 0);
            #endregion
        }

        public static void IncluirNovoPaciente()
        {
            Console.Clear();
            Console.Write("[Novo Paciente]");
            Console.WriteLine("\n");

            var paciente = new Paciente();

            Console.WriteLine("Entre com os dados do novo paciente a ser adicionado na fila de transplante...");
            Console.WriteLine("\n");
            Thread.Sleep(500);

            Console.Write("Nome: ");
            paciente.Nome = Console.ReadLine();

            Console.Write("Telefone: ");
            paciente.Telefone = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nQual é o grau de urgência do paciente? \n(digite um valor de 1 a 5 onde 1 é " +
                "'Sem Urgência' e 5 é 'Muito Urgente')");
            paciente.GrauDeUrgencia = (GrauDeUrgencia)Int32.Parse(Console.ReadLine());

            listaDePacientes.Insere(paciente);

            Console.WriteLine("O paciente {0} foi inserido com sucesso.", paciente.Nome);
        }

        private static void NovoCoracao_ConsultarProximoPaciente()
        {
            var paciente = (Paciente)listaDePacientes.GetPacienteMaiorGrauDeUrgencia();

            Console.WriteLine("O paciente {0} foi transplantado com sucesso. =)", paciente.Nome);
            listaDePacientes.Retira(paciente);
        }

        private static void ConsultarTamanhoFilaDeEspera()
        {
            Console.WriteLine("O tamanho atual da lista de espera de pacientes é: {0}", listaDePacientes.tamanhoLista());
            Thread.Sleep(3000);
        }
        #endregion

        #region Questao 2
        /// <summary>
        /// Questao 2: Implemente um programa utilizando qualquer TAD para cadastrar os contatos de uma lista telefônica.
        /// Para cada contato cadastrado, o programa deverá solicitar: nome, telefone e e-mail. O programa deve permitir
        /// imprimir todos os contatos cadastrados.
        /// </summary>
        private static void Questao2()
        {
            listaDeContatos = new Lista(100);

            #region Questao 1 - [Escolha o que deseja executar]
            int funcaoExecutada;

            do
            {
                Console.Clear();
                Console.WriteLine("------[Questao 1]------");
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
            //-----NÃO TÁ IMPRIMINDO CERTO
            while (!listaDeContatos.IsListaVazia())
                listaDeContatos.Imprime();
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

        #region Questao 4
        /// <summary>
        /// Questao 4: Sabendo que possuímos as pilhas (Pa, Pb, Pc) e os blocos (B1, B2, B3), implemente uma solução, através
        /// de um simulador, utilizando apenas operações de pilha, para resultarmos na mesma composição e ordem dos blocos
        /// (B1, B2, B3) na pilha Pb.
        /// </summary>
        private static void Questao4()
        {
            P1 = new Pilha(3);
            P2 = new Pilha(3);
            P3 = new Pilha(3);

            for (int i = 1; i <= 3; i++)
            {
                P1.Empilha(i);
            }

            for (int i = 1; i <= 3; i++)
            {
                P3.Empilha(P1.Desempilha());
            }

            for (int i = 1; i <= 3; i++)
            {
                P2.Empilha(P3.Desempilha());
            }

        }
        #endregion

        #region Questao 5
        /// <summary>
        /// Questao 5: Dada a sequência de números: 3 4 9 2 5 8 2 1 7 4 6 2 9 8 5 1, ordene-a em ordem crescente segundo os 
        /// seguintes algoritmos, apresentando a sequência obtida após cada passo do algoritmo:
        ///     a. InsertionSort
        ///     b. SelectionSort
        ///     c. ShellSort
        ///     d. QuickSort
        /// </summary>
        private static void Questao5()
        {
            int[] sequenciaDeNumeros = { 3, 4, 9, 2, 5, 8, 2, 1, 7, 4, 6, 2, 9, 8, 5, 1 };

            ordenacao = new Ordenacao();

            ////     a. InsertionSort
            //ordenacao.Insercao(sequenciaDeNumeros);

            ////     b. SelectionSort
            //ordenacao.Selecao(sequenciaDeNumeros);

            ////     c. ShellSort
            //ordenacao.Shellsort(sequenciaDeNumeros);

            ////     d. QuickSort
            //ordenacao.Quicksort(sequenciaDeNumeros);

        }
        #endregion

        #region Questao 6
        /// <summary>
        /// Questao 6: Inclua nos algoritmos acima (InsertionSort, SelectionSort, ShellSort e QuickSort) métodos que permitam a ordenação dos elementos também em ordem decrescente.
        /// </summary>
        private static void Questao6()
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