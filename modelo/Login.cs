using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_Horas.modelo
{
    class Login
    {
        public string NOME;
        private string senha;

        public Login()
        {
        }

        public Login(string nOME, string senha)
        {
            NOME = nOME;
            this.senha = senha;
        }

        public string Senha { get => senha; set => senha = value; }
    }
}
