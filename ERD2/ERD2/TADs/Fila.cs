using ERD2.TADs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERD2.TADs
{
    public class Fila : IFila //encadeada
    {
        //private Object[] item; //isso é pra fila com arranjo
        private Celula frente;
        private Celula tras;

        public Fila()
        {
            frente = new Celula();
            tras = frente;
            frente.prox = null;
        }

        #region [Métodos herdados da interface base]

        public void Enfileira(object x)
        {
            this.tras.prox = new Celula();
            this.tras = this.tras.prox;
            this.tras.item = x;
            this.tras.prox = null;
        }

        public Object Desenfileira()
        {
            Object item = null;
            if (this.IsFilaVazia())
                throw new Exception("Erro: A fila está vazia!");
            frente = frente.prox;
            item = frente.item;
            return item;
        }


        public bool IsFilaVazia()
        {
            return (frente == tras);
        }
        #endregion

        private class Celula
        {
            internal Object item;
            internal Celula prox;
        }
    }
}