using Banco_de_Horas.bd;
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
    public partial class CadastroSetor : Form
    {
        public CadastroSetor()
        {
            InitializeComponent();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Setor setor = new Setor(txtSetor.Text);
            SetorBd bd = new SetorBd();
            bd.salvar(setor);
            txtSetor.Text = " ";
            MessageBox.Show("Setor salvo !");
        }
    }
}
