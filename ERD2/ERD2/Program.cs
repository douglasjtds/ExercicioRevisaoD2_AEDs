using ERD2.Atividade_1;
using ERD2.TADs;
using ERD2.TADs.Implementacoes;
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
        //private static Lista listaDeContatos;
        private static Fila filaDePacientes;


        static void Main(string[] args)
        {
            #region [Escolha a Atividade que deseja executar]
            int numAtividade;

            do
            {
                Console.Clear();
                Console.WriteLine("------[Exercício de Revisão 2 - Prova D2]------");
                Console.WriteLine("\n");
                Console.WriteLine("[ 1 ] Atividade 1");
                Console.WriteLine("[ 2 ] Atividade 2");
                Console.WriteLine("[ 3 ] Atividade 3");
                Console.WriteLine("[ 4 ] Atividade 4");
                Console.WriteLine("[ 5 ] Atividade 5");
                Console.WriteLine("[ 6 ] Atividade 6");

                Console.WriteLine("\n");

                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha a Atividade que deseja executar: ");
                numAtividade = Int32.Parse(Console.ReadLine());
                switch (numAtividade)
                {
                    case 1:
                        Atividade1();
                        break;
                    case 2:
                        Atividade2();
                        break;
                    case 3:
                        Atividade3();
                        break;
                    case 4:
                        Atividade4();
                        break;
                    case 5:
                        Atividade5();
                        break;
                    case 6:
                        Atividade6();
                        break;
                    default:
                        SaiPrograma();
                        break;
                }

            } while (numAtividade != 0);
            #endregion
        }

        #region Atividade 1
        /// <summary>
        /// Atividade 1: Um hospital de cardiologia precisa de um sistema para efetuar o cadastro de pacientes que necessitam
        /// de doação de coração. Para cada paciente que é incluído no sistema deve ser informado o nome, telefone e o grau de
        /// urgência para transplante. O grau de urgência é definido na seguinte escala: (5) Muito urgente; (4) Urgente; (3) Médio;
        /// (2) Pouco urgente; (1) Sem urgência. Sempre que é o hospital recebe um novo coração o sistema é consultado para
        /// obter o próximo paciente que deverá ser operado. O sistema informa o nome e o telefone do paciente.Também a
        /// qualquer momento é possível visualizar o tamanho da fila de espera. Observação: os dados não precisam ser
        /// persistidos em arquivos, podem ficar armazenados somente na memória.
        /// </summary>
        private static void Atividade1()
        {
            filaDePacientes = new Fila(10);

            #region Atividade 1 - [Escolha o que deseja executar]
            int funcaoExecutada;

            do
            {
                Console.Clear();
                Console.WriteLine("------[Atividade 1]------");
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
            Thread.Sleep(500);

            Console.Write("Nome: ");
            paciente.Nome = Console.ReadLine();

            Console.Write("Telefone: ");
            paciente.Telefone = Int32.Parse(Console.ReadLine());

            Console.Write("Grau de Urgência: ");
            paciente.GrauDeUrgencia = (GrauDeUrgencia)Int32.Parse(Console.ReadLine());

            filaDePacientes.Enfileira(paciente);

            Console.WriteLine("O paciente {0} foi inserido com sucesso.", paciente.Nome);
        }

        private static void NovoCoracao_ConsultarProximoPaciente()
        {
            throw new NotImplementedException();
        }

        private static void ConsultarTamanhoFilaDeEspera()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Atividade 2
        /// <summary>
        /// Atividade 2: Implemente um programa utilizando qualquer TAD para cadastrar os contatos de uma lista telefônica.
        /// Para cada contato cadastrado, o programa deverá solicitar: nome, telefone e e-mail. O programa deve permitir
        /// imprimir todos os contatos cadastrados.
        /// </summary>
        private static void Atividade2()
        {

        }
        #endregion

        #region Atividade 3
        /// <summary>
        /// 
        /// </summary>
        private static void Atividade3()
        {
        }
        #endregion

        #region Atividade 4
        /// <summary>
        /// 
        /// </summary>
        private static void Atividade4()
        {
        }
        #endregion

        #region Atividade 5
        /// <summary>
        /// 
        /// </summary>
        private static void Atividade5()
        {
        }
        #endregion

        #region Atividade 6
        /// <summary>
        /// 
        /// </summary>
        private static void Atividade6()
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