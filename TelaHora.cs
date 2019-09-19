using Banco_de_Horas.bd;
using Banco_de_Horas.modelo;
using Bancod_de_Horas.bd;
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
        private ExtraBd extraBd = new ExtraBd();
        private Funcionario funcionario;
        private DataTable dt;
        private int total, hr, min, hrD, minD = 0;
        private int desconto = 0;
        public Form2()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Extra horaExtra;

            int quantidadeH = Int32.Parse(txtHora.Text);
            int quantidadeMin = Int32.Parse(txtMin.Text);
            DateTime dia = escolhaDia.Value;
            string obs = txtObs.Text;
            int codFk = funcionario.Matricula;

            horaExtra = new Extra(quantidadeH, quantidadeMin, dia, obs, 0, funcionario);

            extraBd.salvar(horaExtra);

            MessageBox.Show("Horas extras foram adicionadas !");
            txtHora.Text = "";
            txtMin.Text = "";
            txtObs.Text = "";

            //haversH = 0;
            hr = 0;
            hrD = 0;
            min = 0;
            minD = 0;

            defineF();
            //  defineTotal();

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
            lblMatricula.Text = funcionario.Matricula.ToString();


            dt = extraBd.listar(codigoI);

            tabelaExtra.DataSource = dt;
            tabelaExtra.Columns[0].Visible = false;
            tabelaExtra.Columns[1].HeaderText = "Horas";
            tabelaExtra.Columns[2].HeaderText = "Minutos";
            tabelaExtra.Columns[3].HeaderText = "Data";
            tabelaExtra.Columns[4].HeaderText = "Observação";
            tabelaExtra.Columns[4].Width = 190;
            tabelaExtra.Columns[5].HeaderText = "Compensado";
            tabelaExtra.Columns[5].Width = 70;
            tabelaExtra.Columns[6].Visible = false;
            defineTotal();
        }
        private void defineTotal()
        {
            foreach (DataRow linha in dt.Rows)
            {
                if (linha[5].ToString().Equals("0"))
                {
                    hr += Int32.Parse(linha[1].ToString());
                    min += Int32.Parse(linha[2].ToString());
                }
                else
                {
                    hrD += Int32.Parse(linha[1].ToString());
                    minD += Int32.Parse(linha[2].ToString());
                }
            }

            if (min > 59)
            {
                for (int cont = 0; cont <= min; cont += 60)
                {
                    min -= 60;
                    hr++;
                }


            }

            if (minD > 59)
            {
                for (int cont = 0; cont <= minD; cont += 60)
                {
                    minD -= 60;
                    hrD++;
                }


            }
            total = hr - hrD;
            lblTotal.Text = total.ToString();
            int minutosT = min - minD;
            lblTotalmin.Text = minutosT.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void LbNome_Click(object sender, EventArgs e)
        {

        }

        private void TabelaExtra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnDescontar_Click(object sender, EventArgs e)
        {

            Extra horaExtra;

            int quantidadeCompH = Int32.Parse(compH.Text);
            int quantidadeCompMin = Int32.Parse(compM.Text);
            int haversH = Int32.Parse(lblTotal.Text);
            int haversMin = Int32.Parse(lblTotalmin.Text);
            DateTime dia = escolheDiaComp.Value;
            string obs = txtObsComp.Text;
            int codFk = funcionario.Matricula;

            horaExtra = new Extra(quantidadeCompH, quantidadeCompMin, dia, obs, 1, funcionario);
            if ( (haversH > quantidadeCompH) || (haversH == quantidadeCompH && haversMin >= quantidadeCompMin) )
            {
                extraBd.salvar(horaExtra);

                MessageBox.Show("Horas compensadas !!");
            }
            else
                MessageBox.Show("Nao ha horas suficientes !!");

            dt.Clear();
            compH.Text = "";
            compM.Text = "";
            txtObsComp.Text = "";

            haversH = 0;
            hr = 0;
            hrD = 0;
            min = 0;
            minD = 0;
            total = 0;

            defineF();
            //  defineTotal();

        }
    }
}
