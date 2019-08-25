using MySql.Data.MySqlClient;
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
    public partial class TelaCadastroProfes : Form
    {
        private DataTable dt;
        private EscolaBD escolaBd = new EscolaBD();
        private ProfessorBD bd = new ProfessorBD();
        public TelaCadastroProfes()
        {
            InitializeComponent();
            populaCombo();

        }

        private void populaCombo()
        {
            DataTable listaCombo = escolaBd.listar();
            
            comboBox1.ValueMember = "id,nome";
            comboBox1.DisplayMember = "nomeEscola";
            comboBox1.SelectedItem = "escolaId";

            comboBox1.DataSource = listaCombo;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboEscola_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            // montar objeto

            string nomeP = txtNome.Text;
            string cpfP = txtCpf.Text;
            string emailP = txtEmail.Text;
            int idEscola = comboBox1.SelectedIndex;
            idEscola++;
           // arrumar combobox escola

            // limpar os campos
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEmail.Text = "";
         
           Escola escola = escolaBd.selecionado(idEscola);
           Professor profe = new Professor("10", nomeP, cpfP, emailP, escola);
            bd.salvar(profe);

            MessageBox.Show("Professor registrado !  ");
        }

        private void TelaCadastroProfes_Load(object sender, EventArgs e)
        {

        }
    }
}
