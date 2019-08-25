using Banco_de_Horas.conexao;
using Bancod_de_Horas.modelo;
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
    class SetorBd
    {

        private MySqlConnection conexao;
        private MySqlCommand comando = new MySqlCommand();
        private MySqlDataReader DR;
        private Conecta c;

        public SetorBd()
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

        public void salvar(Setor s)
        {
            comando.CommandText = "INSERT INTO bancohoras.setores (nome) VALUES (@nome)";

            comando.Parameters.AddWithValue("@nome", s.NomeSetor);

            try
            {
                comando.Connection = c.inicia();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }


        }

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

        public Setor selecionado(int id)
        {
            Setor setor = new Setor("a");
            MySqlDataReader reader;
            conexao.Close();
            conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT * FROM bancohoras.setores WHERE @id = id", conexao);
                comando.Parameters.AddWithValue("@id", id);
                reader = comando.ExecuteReader();
                List<Setor> lista = new List<Setor>();
                string nome = "z";
                string ids = "00";
                while (reader.Read())
                {
                    ids = reader[0].ToString();
                    nome = reader[1].ToString();
                }
                int idi = Int32.Parse(ids);
                setor = new Setor(nome);
                setor.IdSetor = idi;

            }
            catch (Exception e)
            {

            }
            return setor;

        }


    }
}
