using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERD2.Ordenação.Interfaces
{
    public interface IOrdenacao
    {
        //void Selecao(Item[] v, int n);
        void Selecao(int[] vetor);
        //void Insercao(Item[] v, int n);
        void Insercao(int[] vetor);
        //void Shellsort(Item[] v, int n);
        void Shellsort(int [] vetor);
        //void Quicksort(Item[] v, int n);
        void Heapsort(Item[] v, int n);
    }
}