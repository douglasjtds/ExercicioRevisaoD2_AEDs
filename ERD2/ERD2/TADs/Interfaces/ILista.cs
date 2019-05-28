using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERD2.TADs.Interfaces
{
    public interface ILista
    {
        void CriaListaVazia(int maxTam);
        Object Pesquisa(Object chave);
        void Insere(Object chave);
        Object Retira(Object chave);
        Object RetiraPrimeiro();
        Object Primeiro();
        bool IsListaVazia();
    }
}