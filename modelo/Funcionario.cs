using Bancod_de_Horas.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_Horas.modelo
{
    class Funcionario
    {
   
        private int matricula;
        private string nomeFuncionario;
        private string cargo;
        private int ativo;
        private Setor setor;

        public int Matricula { get => matricula; set => matricula = value; }
        public string NomeFuncionario { get => nomeFuncionario; set => nomeFuncionario = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Ativo { get => ativo; set => ativo = value; }
        internal Setor Setor { get => setor; set => setor = value; }

        public Funcionario(int matricula, string nomeFuncionario, string cargo, int ativo, Setor setor)
        {
            Matricula = matricula;
            NomeFuncionario = nomeFuncionario;
            Cargo = cargo;
            Ativo = ativo;
            Setor = setor;
        
        }

        public Funcionario()
        {
        }
    }
}
