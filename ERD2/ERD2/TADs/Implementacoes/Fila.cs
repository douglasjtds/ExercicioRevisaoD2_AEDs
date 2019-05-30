using ERD2.TADs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERD2.TADs.Implementacoes
{
    public class Fila : IFila //com arranjo
    {
        private Object[] item;

        private int frente, tras;

        public Fila(int maxTam) //cria fila vazia
        {
            this.item = new Object[maxTam];
            this.frente = 0;
            this.tras = this.frente;
        }

        #region [Métodos herdados da interface base]

        public void Enfileira(Object x)
        {
            if ((this.tras + 1) % this.item.Length == this.frente) //NÃO ENTENDI ISSO?
                throw new Exception("Erro: A fila está cheia!");
            this.item[this.tras] = x; //inserindo no último elemento
            this.tras = (this.tras + 1) % this.item.Length;
        }

        public Object Desenfileira()
        {
            if (this.IsFilaVazia())
                throw new Exception("Erro: A fila está vazia!");
            Object item = this.item[this.frente];
            this.frente = (this.frente + 1) % this.item.Length;
            return item;
        }

        public bool IsFilaVazia()
        {
            return (this.frente == this.tras);
        }
        #endregion
    }
}