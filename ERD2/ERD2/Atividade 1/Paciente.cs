using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERD2.Questao_1
{
    public class Paciente
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public GrauDeUrgencia GrauDeUrgencia { get; set; }
    }
}