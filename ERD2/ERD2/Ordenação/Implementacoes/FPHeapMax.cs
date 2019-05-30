using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERD2.Ordenação.Interfaces;

namespace ERD2.Ordenação.Implementacoes
{
    public class FPHeapMax
    {
        private Item[] v;
        private int n;

        public FPHeapMax(Item [] v)
        {
            this.v = v;
            this.n = this.v.Length - 1;
        }
    }
}