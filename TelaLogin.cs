﻿using Banco_de_Horas.bd;
using Banco_de_Horas.modelo;
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
    public partial class TelaLogin : Form
    {
        private TelaInicial incial;
        public TelaLogin()
        {
            InitializeComponent();
        }

        public TelaInicial Incial { get => incial; set => incial = value; }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login login;
            LoginBd bd = new LoginBd();
            string n = txtNome.Text;
            string s = txtSenha.Text;

            login = bd.logar(n, s);
            if (login.NOME.Equals(n))
            {
                MessageBox.Show("Tudo OK");
                txtNome.Text = "";
                txtSenha.Text = "";
                incial.ativaTela();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Nome ou senha incorretos");
                txtNome.Text = "";
                txtSenha.Text = "";
            }

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
