using Ponto_Educacional.bd;
using Ponto_Educacional.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponto_Educacional.telas
{
    public partial class TelaCadastroEscola : Form
    {
        public TelaCadastroEscola()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Escola escola = new Escola(txtNomeEscola.Text);
            EscolaBD bd = new EscolaBD();
            bd.salvar(escola);
            MessageBox.Show("Escola salva !");
            txtNomeEscola.Text = " ";
        }
    }
}
