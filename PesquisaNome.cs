using Banco_de_Horas.bd;
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
    public partial class PesquisaNome : Form
    {
        private string nome;
        private DataTable dt;
        private FuncionarioBd funcionarioBd = new FuncionarioBd();
        public PesquisaNome()
        {
            InitializeComponent();

        }

        public void setaNome(string n)
        {
            this.nome = n;
            dt = funcionarioBd.pesquisa(n);

            tabelaFuncionario.DataSource = dt;
            tabelaFuncionario.Columns[2].Visible = false;
            tabelaFuncionario.ReadOnly = true;
        }
        private void PesquisaNome_Load(object sender, EventArgs e)
        {

        }

        private void TabelaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Form2 telaHora = new Form2();
            int idx = tabelaFuncionario.CurrentCell.RowIndex;
            telaHora.defineMatricula(tabelaFuncionario.Rows[idx].Cells[0].Value.ToString() );
            telaHora.Visible = true;
            this.Visible = false;
            
        }
    }
}
