using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERD2.TADs.Interfaces
{
    public interface IListaEncadeada //utilizando auto-referenciamento (exemplo Aula 4)
    {
        Object Pesquisa(Object chave);
        void Insere(Object x);
        Object Retira(Object chave);
        Object RetiraPrimeiro();
        Object Primeiro();
        bool IsListaVazia();
    }
}