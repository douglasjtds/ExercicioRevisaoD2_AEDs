using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERD2.TADs.Interfaces
{
    public interface IPilha
    {
        void Empilha(Object x);
        Object Desempilha();
        bool IsPilhaVazia();
        int Tamanho();    }
}