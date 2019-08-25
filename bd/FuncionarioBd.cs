using MySql.Data.MySqlClient;
using Ponto_Educacional.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using Banco_de_Horas.conexao;
using Banco_de_Horas.modelo;

namespace Banco_de_Horas.bd
{
    class FuncionarioBd
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private Conecta c;
        private MySqlDataAdapter mDa = new MySqlDataAdapter();
        

        public FuncionarioBd()
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

        public DataTable listar()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("escolaId");
            dt.Columns.Add("nomeEscola");
            MySqlDataReader reader;
            conexao.Close();
            conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT * FROM pnteduc.escola", conexao);
                reader = comando.ExecuteReader();

                dt.Load(reader);

            } catch (Exception e)
            {

            }


            return dt;
        }

        

        public void salvar(Funcionario f )
        {
            comando = new MySqlCommand();
            comando.CommandText = "INSERT INTO bancohoras.funcionario (id, nome, cargo, ativo, setorfk) VALUES (@cod, @nome, @cargo, @status, @setor);";

            comando.Parameters.AddWithValue("@cod",f.Matricula);
            comando.Parameters.AddWithValue("@nome", f.NomeFuncionario);
            comando.Parameters.AddWithValue("@cargo",f.Cargo);
            comando.Parameters.AddWithValue("@status",f.Ativo);
            comando.Parameters.AddWithValue("@setor",f.Setor.IdSetor);

            try
            {
                comando.Connection = c.inicia();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }

        }


    }

    
    
}
