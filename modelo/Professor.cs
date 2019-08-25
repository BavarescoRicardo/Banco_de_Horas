using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto_Educacional.modelo
{
    class Professor
    {
        private int idProfessor;
        private string matricula;
        private string nome;
        private string cpf;
        private string email;
        private Escola escola;

        public Professor(string matricula, string nome, string cpf, string email, Escola escola)
        {;
            this.matricula = matricula;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.escola = escola;
        }

        public int IdProfessor { get => idProfessor; set => idProfessor = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        internal Escola Escola { get => escola; set => escola = value; }
    }
}
