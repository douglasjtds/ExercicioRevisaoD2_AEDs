using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERD2
{
    public class Program
    {
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
        /// 
        /// </summary>
        private static void Atividade1()
        {
        }
        #endregion

        #region Atividade 2
        /// <summary>
        /// 
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