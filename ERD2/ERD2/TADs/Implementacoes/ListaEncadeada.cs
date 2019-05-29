﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERD2.TADs.Implementacoes
{
    public class ListaEncadeada
    {
        public class Celula
        {
            internal Object item;
            internal Celula prox;
            //internal object primeiro;
            //internal Celula pos;
        }
        private Celula primeiro, ultimo, pos;

        public ListaEncadeada() //cria lista vazia
        {
            this.primeiro = new Celula();
            this.primeiro.prox = null;
            this.pos = this.primeiro;
            this.ultimo = this.primeiro;
            this.primeiro.prox = null;
        }

        #region Métodos herdados da interface
        public object Pesquisa(object chave)
        {
            if (this.IsListaVazia() || chave == null)
                return null;

            Celula aux = this.primeiro;
            while (aux.prox != null)
            {
                //if (((Contato)(aux.prox.item)).Nome.Equals(chave)) // ----- Implementação com o cast para contato para conseguir pesquisar pelo nome
                if (aux.prox.item.Equals(chave)) // ----- Implementação da forma que foi feita no livro
                    return aux.prox.item;
                aux = aux.prox;
            }
            return null;
        }

        public void Insere(object x)
        {
            this.ultimo.prox = new Celula();
            this.ultimo = this.ultimo.prox;
            this.ultimo.item = x;
            this.ultimo.prox = null;
        }

        public object Retira(object chave)
        {
            if (this.IsListaVazia() || (chave == null))
                throw new Exception("Erro : Lista vazia ou chave invalida");
            Celula aux = this.primeiro;
            //while (aux.prox != null && !((Contato)(aux.prox.item)).Nome.Equals(chave)) // ----- Implementação com o cast para contato para conseguir pesquisar pelo nome
            while (aux.prox != null && !aux.prox.item.Equals(chave))
                aux = aux.prox;
            if (aux.prox == null)
                return null; // não encontrada
            Celula q = aux.prox;
            Object item = q.item;
            aux.prox = q.prox;
            if (aux.prox == null)
                this.ultimo = aux;
            return item;
        }

        public object RetiraPrimeiro()
        {
            if (this.IsListaVazia())
                throw new Exception("Erro : Lista vazia");
            Celula aux = primeiro;
            Celula q = aux.prox;
            Object item = q.item;
            aux.prox = q.prox;
            if (aux.prox == null)
                this.ultimo = aux;
            return item;
        }
        public object Primeiro()
        {
            this.pos = primeiro;
            return Proximo();
        }

        public bool IsListaVazia()
        {
            return (this.primeiro == this.ultimo);
        }
        #endregion

        public Object Proximo()
        {
            this.pos = this.pos.prox;
            if (this.pos == null)
                return null;
            else
                return this.pos.item;
        }

        public void Imprime()
        {
            Celula aux = this.primeiro.prox;
            while (aux != null)
            {
                Console.WriteLine(aux.item.ToString());
                aux = aux.prox;
            }
        }
    }
}