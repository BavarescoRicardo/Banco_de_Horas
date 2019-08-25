using Banco_de_Horas.conexao;
using Bancod_de_Horas.modelo;
using MySql.Data.MySqlClient;
using Ponto_Educacional.modelo;
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
                /*
                  
                int n = 0;
                foreach (DataRow linha in dt.Rows)
                {
                    if (dt.Rows[n][1] != null)
                    {
                        int cod = Int32.Parse(dt.Rows[n][0].ToString()) ;
                        string nomeS = dt.Rows[n][1].ToString();
                      
                        n++;
                    }
                    else
                        break;
                }
               

                dt.Columns[1].ColumnName = "Setor";
   
                dt.Columns[2].ColumnMapping = MappingType.Hidden;
 

                 */

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
                while (reader.Read())
                {
                    string idS = reader[0].ToString();
                    nome = reader[1].ToString();

                    int idi = Int32.Parse(idS);
                    
                }
                setor = new Setor(nome);

            }
            catch (Exception e)
            {

            }
            return setor;

        }


    }
}
