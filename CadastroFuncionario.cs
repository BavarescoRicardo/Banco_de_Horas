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
    public partial class CadastroFuncionario : Form
    {
        private SetorBd setorBd = new SetorBd();
        public CadastroFuncionario()
        {
            InitializeComponent();
            populaCombo();
            txtMatricula.Text = " ";
            txtCargo.Text = " ";
            txtNome.Text = " ";
        }

        private void populaCombo()
        {
            DataTable listaCombo = setorBd.listar();

            comboSetor.ValueMember = "Setor";
            comboSetor.DisplayMember = "nome";
            comboSetor.SelectedItem = "id";

            comboSetor.DataSource = listaCombo;

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {

            if (txtMatricula.Text.Equals(" ") || txtNome.Text.Equals(" ") )
            {
                MessageBox.Show("Preencha todos os campos !");

            }
            else
            {
                int cod = Int32.Parse(txtMatricula.Text);
                string nome = txtNome.Text;
                string cargo = txtCargo.Text;

                int ativo = 0;
                if (cbAtivo.Checked)
                    ativo = 1;
                int idSetor = comboSetor.SelectedIndex;
                SetorBd setorBd = new SetorBd();
                Setor setor;
                // receber setor do banco pelo id do comboBox
                setor = setorBd.selecionado(idSetor);
                Funcionario funcionario = new Funcionario(cod, nome, cargo, ativo, setor);

                txtNome.Text = " ";
                txtCargo.Text = " ";
                txtMatricula.Text = " ";

                FuncionarioBd bd = new FuncionarioBd();
                bd.salvar(funcionario);
                MessageBox.Show("Funcionario Salvo !");
            }
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
