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
    public partial class TelaVisualizarProfess : Form
    {
        private ProfessorBD profeBd = new ProfessorBD();
        private EscolaBD escolaBd = new EscolaBD();
        public TelaVisualizarProfess()
        {
            InitializeComponent();

            // definir colunas 
            /*
            comando.Parameters.AddWithValue("matricula");

            comando.Parameters.AddWithValue("nome", p.Nome);
            comando.Parameters.AddWithValue("cpf", p.Cpf);
            comando.Parameters.AddWithValue("email", p.Email);
            comando.Parameters.AddWithValue("escola", p.Escola.getId());
            */
            DataTable dt = profeBd.listar();
            tabelaProfessores.DataSource = dt;
            /*
             * List<Professor> listaP = new List<Professor>();
             * foreach (Professor profe in  listaP)
            {

            }
            */
        }

        private void TelaVisualizarProfess_Load(object sender, EventArgs e)
        {

        }

        private void TabelaProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
