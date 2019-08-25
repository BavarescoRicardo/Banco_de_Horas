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
        // private int quantidade;
        private int extraHora;
        private int extraMin;
        private DateTime dia;
        private string observacao;
        private Funcionario funcionario;

        public Extra(int extraHora, int extraMin, DateTime dia, string observacao, Funcionario funcionario)
        {
            this.extraHora = extraHora;
            this.extraMin = extraMin;
            this.dia = dia;
            this.observacao = observacao;
            this.funcionario = funcionario;
        }

        public int IdExtra { get => idExtra; set => idExtra = value; }
        public int ExtraHora { get => extraHora; set => extraHora = value; }
        public int ExtraMin { get => extraMin; set => extraMin = value; }
        public DateTime Dia { get => dia; set => dia = value; }
        public string Observacao { get => observacao; set => observacao = value; }
      //  public int Quantidade { get => quantidade; set => quantidade = value; }
        internal Funcionario Funcionario { get => funcionario; set => funcionario = value; }
    }
}
