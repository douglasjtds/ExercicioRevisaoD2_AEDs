using ERD2.Ordenação.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERD2.Ordenação.Implementacoes
{
    public class Ordenacao : IOrdenacao
    {
        public void Selecao(Item[] v, int n)
        {
            int i;
            for (i = 1; i <= n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j <= n; j++)
                {
                    if (v[j].Compara(v[min]) < 0)
                        min = j;
                }
                Item x = v[min];
                v[min] = v[i];
                v[i] = x;
            }
        }

        public void Insercao(Item[] v, int n)
        {
            int j;
            for (int i = 2; i <= n; i++)
            {
                Item x = v[i];
                j = i - 1;
                v[0] = x; // sentinela
                while (x.Compara(v[j]) < 0)
                {
                    v[j + 1] = v[j]; j--;
                }
                v[j + 1] = x;
            }
        }

        public void Shellsort(Item[] v, int n)
        {
            int h = 1;
            do h = h * 3 + 1;
            while (h < n);
            do
            {
                h /= 3; //h = h / 3  -> a /= b is equivalent to a = a / b
                for (int i = h + 1; i <= n; i++)
                {
                    Item x = v[i];
                    int j = i;
                    while (v[j - h].Compara(x) > 0)
                    {
                        v[j] = v[j - h]; j -= h;
                        if (j <= h)
                            break;
                    }
                    v[j] = x;
                }
            } while (h != 1);
        }

        #region Quicksort
        private class LimiteParticoes
        {
            internal int i;
            internal int j;
        }

        private static LimiteParticoes Particao(Item[] v, int esq, int dir)
        {
            LimiteParticoes p = new LimiteParticoes();
            p.i = esq;
            p.j = dir;
            Item x = v[(p.i + p.j) / 2]; //obter o pivô x
            do
            {
                while (x.Compara(v[p.i]) > 0)
                    p.i++;
                while (x.Compara(v[p.j]) < 0)
                    p.j--;
                if (p.i <= p.j)
                {
                    Item w = v[p.i];
                    v[p.i] = v[p.j];
                    v[p.j] = w;
                    p.i++;
                    p.j--;
                }
            } while (p.i <= p.j);
            return p;
        }

        /// <summary>
        /// Método de ordenar do QuickSort
        /// </summary>
        private static void Ordena(Item[] v, int esq, int dir)
        {
            LimiteParticoes p = Particao(v, esq, dir);
            if (esq < p.j)
                Ordena(v, esq, p.j);
            if (p.i < dir)
                Ordena(v, p.i, dir);

        }

        public void Quicksort(Item[] v, int n)
        {
            Ordena(v, 1, n);
        }
        #endregion


        #region Heapsort

        public void Heapsort(Item[] v, int n)
        {
            throw new NotImplementedException();
        }
        //public void refaz(int esq, int dir)
        //public void constroi()
        //public Item max()
        //public Item retiraMax() throws Exception
        //public void aumentaChave(int i, Object chaveNova)
        //throws Exception
        //public void insere(Item x) throws Exception

        #endregion
    }
}