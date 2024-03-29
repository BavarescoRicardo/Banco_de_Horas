﻿using System;
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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Incial = this;
            telaLogin.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form2 telaHora = new Form2();
            telaHora.defineMatricula(txtFuncionario.Text);
            telaHora.Visible = true;
        }

        public void ativaTela()
        {
            txtFuncionario.Enabled = true;
            btnMatricula.Enabled = true;
            btnNome.Enabled = true;
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void FuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
            cadastroFuncionario.Visible = true;
        }

        private void SetorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroSetor setor = new CadastroSetor();
            setor.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string nome = txtFuncionario.Text;
            PesquisaNome pesquisa = new PesquisaNome();
            pesquisa.setaNome(nome);
            pesquisa.Visible = true;
        }
    }
}
