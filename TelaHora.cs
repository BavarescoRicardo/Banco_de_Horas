using Banco_de_Horas.bd;
using Banco_de_Horas.modelo;
using Bancod_de_Horas.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_de_Horas
{
    public partial class Form2 : Form
    {
        private string codigo;
        private FuncionarioBd funcionarioBd = new FuncionarioBd();
        private Funcionario funcionario;
        public Form2()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        public void defineMatricula(string codigoS)
        {
            this.codigo = codigoS;
            defineF();
        }

        private void defineF()
        {
            
            int codigoI = Int32.Parse(codigo);
            funcionario = funcionarioBd.escolhido(codigoI);
            lbNome.Text = funcionario.NomeFuncionario;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
