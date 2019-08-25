using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto_Educacional.modelo
{
    class Escola
    {
        private int idEscola;
        private string nomeEscola;
        

        public Escola()
        {
        }

        public Escola(string nomeEscola)
        {
            this.NomeEscola = nomeEscola;
        }
        

        public Escola(int id, string nome)
        {
            this.IdEscola = id;
            this.NomeEscola = nome;
        }

        public int IdEscola { get => idEscola; set => idEscola = value; }
        public string NomeEscola { get => nomeEscola; set => nomeEscola = value; }

        public int getId()
         { 
            return this.IdEscola;
         }

    
    }
}
