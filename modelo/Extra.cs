using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_Horas.modelo
{
    class Extra
    {
        private int idExtra;
        private int extraHora;
        private int extraMin;
        private DateTime dia;
        private string observacao;
        private int desconto;
        private Funcionario funcionario;

        public Extra(int extraHora, int extraMin, DateTime dia, string observacao, int desconto, Funcionario funcionario)
        {
            this.ExtraHora = extraHora;
            this.ExtraMin = extraMin;
            this.Dia = dia;
            this.Observacao = observacao;
            this.Desconto = desconto;
            this.Funcionario = funcionario;
        }

        public int IdExtra { get => idExtra; set => idExtra = value; }
        public int ExtraHora { get => extraHora; set => extraHora = value; }
        public int ExtraMin { get => extraMin; set => extraMin = value; }
        public DateTime Dia { get => dia; set => dia = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public int Desconto { get => desconto; set => desconto = value; }
        internal Funcionario Funcionario { get => funcionario; set => funcionario = value; }
    }
}
