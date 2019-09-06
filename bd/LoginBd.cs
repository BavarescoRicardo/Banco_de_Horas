using Banco_de_Horas.conexao;
using Banco_de_Horas.modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_de_Horas.bd
{
    class LoginBd
    {

        private MySqlConnection conexao;
        private MySqlCommand comando = new MySqlCommand();
        private MySqlDataReader DR;
        private Conecta c;

        public LoginBd()
        {
            c = new Conecta();

            try
            {
                conexao = c.inicia();
            }
            catch (Exception)
            {

            }
        }

        public void salvar(Login s) { 
            comando.CommandText = "INSERT INTO bancohoras.login (nome,senha) VALUES (@nome,@pass)";

            comando.Parameters.AddWithValue("@nome", s.NOME);
            comando.Parameters.AddWithValue("@pass", s.NOME);

            try
            {
                comando.Connection = c.inicia();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }


        }
        /*
        public DataTable listar()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nome");


            MySqlDataReader reader;
            conexao.Close();
            conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT * FROM bancohoras.setores;", conexao);
                reader = comando.ExecuteReader();

                dt.Load(reader);

            }
            catch (Exception)
            {

            }


            return dt;
        }
        */
        public Login logar(string nome,string pass)
        {
            Login log = new Login("nada","nada");

            MySqlDataReader reader;
            conexao.Close();
            conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT * FROM bancohoras.login WHERE @nome = nome", conexao);
                comando.Parameters.AddWithValue("@nome", nome);
                reader = comando.ExecuteReader();

                List<Login> lista = new List<Login>();

                while (reader.Read())
                {
                    //if (dt[2].equals(senha)) conferir se senha bate com a passada por parametro
                    if (reader[2].ToString().Equals(pass))
                    {
                        log = new Login(nome, pass);
                        MessageBox.Show("Usuario logado com sucesso  "+nome);
                    }
                }
                

            }
            catch (Exception e)
            {

            }
            
            return log;
            
        }
    }
}
