using ERD2.Atividade_2;
using ERD2.TADs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERD2.TADs.Implementacoes
{
    public class Lista : ILista
    {
        public Object[] item;
        private int primeiro, ultimo, pos;

        public Lista(int maxTam) //cria uma lista vazia
        {
            this.item = new Object[maxTam];
            this.pos = -1;
            this.primeiro = 0;
            this.ultimo = this.primeiro;
        }

        //public void CriaListaVazia(int maxTam)
        //{
        //    item = new Object[maxTam];
        //    pos = -1;
        //    primeiro = 0;
        //    ultimo = primeiro;
        //}


        #region Métodos herdados da interface base
        public object Pesquisa(object chave)
        {
            if (IsListaVazia() || chave == null)
                return null;
            for (int p = 0; p < this.ultimo; p++) //percorre a lista
                if (this.item[p].Equals(chave)) // ----- Implementação da forma que foi feita no livro
                    return item[p]; //retorna o item encontrado

            return null;


            //if (IsListaVazia() || chave == null)
            //    return null;

            //for (int p = 0; p < ultimo; p++) //percorre a lista
            //{
            //    if (((Contato)(item[p])).Nome.Equals(chave)) // ----- Implementação com o cast para contato para conseguir pesquisar pelo nome
            //        return item[p]; //retorna o item encontrado
            //}
            //return null;
        }

        public void Insere(Object chave)
        {
            if (this.ultimo >= this.item.Length)
                throw new Exception("Erro: A lista está cheia.");
            else
            {
                this.item[this.ultimo] = chave;
                ultimo++;
            }
        }

        public object Retira(object chave)
        {
            if (IsListaVazia() || chave == null)
                throw new Exception("Erro : A lista esta vazia");

            int p = 0;
            //while(p < this.ultimo && !this.item[p].Equals(chave)) // ----- Implementação da forma que foi feita no livro
            while (p < ultimo && !((Contato)(this.item[p])).Nome.Equals(chave)) // ----- Implementação com o cast para contato para conseguir pesquisar pelo nome
                p++;

            if (p >= this.ultimo)
                return null;

            Object item = this.item[p];
            this.ultimo--;

            for (int aux = p; aux < this.ultimo; aux++)
                this.item[aux] = this.item[aux + 1];
            return item;
        }

        public object RetiraPrimeiro()
        {
            if (this.IsListaVazia())
                throw new Exception("Erro : A lista esta vazia");

            Object item = this.item[0];
            ultimo = ultimo - 1;

            for (int aux = 0; aux < this.ultimo; aux++)
                this.item[aux] = this.item[aux + 1];
            return item;
        }

        public object Primeiro()
        {
            this.pos = -1;
            return this.Proximo();
        }

        public bool IsListaVazia()
        {
            return (primeiro == ultimo);
        }
        #endregion

        #region Outros métodos que não estão na interface
        public object Proximo()
        {
            this.pos++;
            if (this.pos >= this.ultimo)
                return null;
            else
                return this.item[this.pos];
        }

        public void Imprime()
        {
            for (int aux = this.primeiro; aux < this.ultimo; aux++)
                Console.WriteLine(this.item[aux].ToString());

            Thread.Sleep(1000);
        }

        public int tamanhoLista()
        {
            return this.ultimo;
        }
        #endregion

        public object GetPacienteMaiorGrauDeUrgencia()
        {
            //percorrer a instancia de lista recebida pra verificar o que tem maior grau de urgencia
            //Celula aux = this.primeiro.prox;
            //while (aux != null)
            //{

            //}

            //while(this.ultimo != null)
            //{
            //    //this.
            //}

            return null;
        }

        //public int tamanhoLista()
        //{
        //    return this.ultimo;
        //}



        ////// deixando comentado apenas para referência
        //#region [Atividade 3]
        //public object RetiraUltimo()
        //{
        //    if (IsListaVazia())
        //        throw new Exception("Erro: Lista Vazia.");
        //    ultimo--;
        //    return null;
        //}

        //public int Ultimo()
        //{
        //    return ultimo;
        //}

        //public int TamanhoLista()
        //{
        //    return item.Length;
        //}

        //public void Insere(Object x, Object chave)
        //{
        //    //Object objetoAux = null;
        //    if (ultimo >= item.Length)
        //        Console.WriteLine("Lista cheia!");
        //    else
        //    {
        //        for (int chaveAux = ultimo; chaveAux > Convert.ToInt32(chave); chaveAux--)
        //            item[chaveAux] = item[chaveAux - 1];

        //        item[Convert.ToInt32(chave)] = x;
        //        ultimo = ultimo + 1;
        //    }
        //}

        //public object Concatenar(Object[] objA, Object[] objB)
        //{
        //    Object[] objConcat = new Object[objA.Length + objB.Length];

        //    for (int i = 0; i < objA.Length; i++)
        //        objConcat[i] = objA[i];
        //    for (int j = objA.Length; j < objConcat.Length; j++)
        //        objConcat[j] = objB[j];

        //    return objConcat;
        //}

        //public void Copia(Object[] obj) //CONFERIR COMO SERIA ESSA COPIA
        //{
        //    Object[] objCopiado = new Object[item.Length];
        //    for (int i = 0; i > obj.Length; i++)
        //        objCopiado[i] = obj;
        //}
        //#endregion

        //#region Aula Prática 4 - [Atividade 1]
        ///// <summary>
        ///// Atividade 1: Escreva uma função para trocar os elementos m e n de uma lista por arranjo 
        ///// (onde m e n devem ser chaves dos itens a serem trocados na lista)
        ///// </summary>
        //public void TrocaElementosM_N(object chaveM, object chaveN)
        //{

        //}
        //#endregion
    }
}