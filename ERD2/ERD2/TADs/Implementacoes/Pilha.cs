using ERD2.TADs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERD2.TADs.Implementacoes
{
    public class Pilha : IPilha
    {
        private Object[] item;
        private int topo;

        public Pilha(int maxTam) //cria pilha vazia
        {
            this.item = new Object[maxTam];
            this.topo = 0;
        }

        #region Métodos herdados da interface base
        public void Empilha(object x)
        {
            if (this.topo == this.item.Length)
                throw new Exception("Erro: A pilha está cheia.");
            else
                this.item[this.topo++] = x;
        }

        public object Desempilha()
        {
            if (this.IsPilhaVazia())
                throw new Exception("Erro: A pilha está vazia.");
            return this.item[--this.topo];
        }


        public bool IsPilhaVazia()
        {
            return (this.topo == 0);
        }

        public int Tamanho()
        {
            return this.topo;
        }
        #endregion

        //public string VerificaCadeiaCaracteres(string stringInformada)
        //{
        //    throw new NotImplementedException();
        //    //stringInformada.Split();
        //    //return null;
        //}
    }
}