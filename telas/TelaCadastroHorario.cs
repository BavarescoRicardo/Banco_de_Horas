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
    public partial class TelaCadastroHorario : Form
    {
        public TelaCadastroHorario()
        {
            InitializeComponent();


        }

        private void Button1_Click(object sender, EventArgs e)
        {
       //   MessageBox.Show("Hora "+txtHora.Text+" Minutos "+txtMin.Text);
            tabelaHorarios.Rows.Add(txtHora.Text, txtMin.Text);
            txtMin.Text = "  ";
            txtHora.Text = " ";
            txtFunc.Text = " ";
        }

        private void TabelaHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int diaS = comboDia.SelectedIndex;
            Horarios h = new Horarios(2,txtHora.Text,txtMin.Text);
            HorarioBD bd = new HorarioBD();
            bd.salvar(h);

            // limpar os campos txt
            txtMin.Text = "  ";
            txtHora.Text = " ";
            txtFunc.Text = " ";
            MessageBox.Show("O horario foi salvo ! " + comboDia.SelectedItem.ToString() );
            int nlinha = tabelaHorarios.Rows.Count - 1;

            for (int linha = 0; linha < nlinha; linha ++)
            {
             //     MessageBox.Show(tabelaHorarios.Rows[linha].Cells[0].Value.ToString()+" "+tabelaHorarios.Rows[linha].Cells[1].Value.ToString());

            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
