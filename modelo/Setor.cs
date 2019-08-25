using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancod_de_Horas.modelo

{
    class Setor
    {
        private int idSetor;
        private string nomeSetor;

        public int IdSetor { get => idSetor; set => idSetor = value; }
        public string NomeSetor { get => nomeSetor; set => nomeSetor = value; }

        public Setor(string nomeSetor)
        {
            NomeSetor = nomeSetor;
            
        }
    }       
}
