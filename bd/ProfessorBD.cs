using MySql.Data.MySqlClient;
using Ponto_Educacional.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponto_Educacional.bd
{
    class ProfessorBD
    {

        private MySqlConnection conexao;
        private MySqlCommand comando = new MySqlCommand();
        private MySqlDataReader DR;
        private Conecta c;

        public ProfessorBD()
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

        public void salvar(Professor p)
        {
            comando.CommandText = "INSERT INTO professor (matricula,nome,cpf,email,escolaId) VALUES (@matricula,@nome,@cpf,@email,@escola)";

            comando.Parameters.AddWithValue("@matricula", p.Matricula);

            comando.Parameters.AddWithValue("@nome", p.Nome);
            comando.Parameters.AddWithValue("@cpf", p.Cpf);
            comando.Parameters.AddWithValue("@email", p.Email);
            comando.Parameters.AddWithValue("@escola", p.Escola.getId());

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
            EscolaBD escolaBd = new EscolaBD();
            Escola e = new Escola();
            DataTable dt = new DataTable();
            dt.Columns.Add("professorId");
            // dt.Columns.Add("matricula");
            dt.Columns.Add("nome");
            dt.Columns.Add("cpf");
            dt.Columns.Add("email");
            dt.Columns.Add("escolaId");

            MySqlDataReader reader;
            conexao.Close();
            conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT * FROM pnteduc.professor", conexao);
                reader = comando.ExecuteReader();

                dt.Load(reader);
                // trocar escola.nome por escolaId na tabela
                int n = 0;
                foreach (DataRow linha in dt.Rows)
                {
                    if (dt.Rows[n][4] != null)
                    {
                        string idEs = dt.Rows[n][4].ToString();
                        int idE = Int32.Parse(idEs);
                        e = escolaBd.selecionado(idE);
                        
                        dt.Rows[n][4] = e.NomeEscola;
                        n++;
                    }
                    else
                        break;
                }
               

                dt.Columns[0].ColumnName = "Matricula";
                dt.Columns[4].ColumnName = "Escola";
                dt.Columns[5].ColumnMapping = MappingType.Hidden;

            }
            catch (Exception)
            {

            }

            
            return dt;
        }


    }
}
