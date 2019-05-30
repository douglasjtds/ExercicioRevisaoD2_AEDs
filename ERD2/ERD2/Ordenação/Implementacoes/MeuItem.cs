using ERD2.Ordenação.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERD2.Ordenação.Implementacoes
{
    public class MeuItem : Item
    {
        private int chave;

        public MeuItem(int chave)
        {
            this.chave = chave;
        }

        public int Compara(Item it)
        {
            MeuItem item = (MeuItem)it;
            if (this.chave < item.chave)
                return -1;
            else if (this.chave > item.chave)
                return 1;
            return 0;
        }

        public void AlteraChave(object chave)
        {
            int ch = (int)chave;
            this.chave = ch;
        }
        public Object RecuperaChave()
        {
            return chave;
        }
    }
}