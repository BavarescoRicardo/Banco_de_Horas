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

namespace Ponto_Educacional.bd
{
    class EscolaBD
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private Conecta c;
        private List<Escola> lista = new List<Escola>();
        private MySqlDataAdapter mDa = new MySqlDataAdapter();
        

        public EscolaBD()
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

            }catch (Exception e)
            {

            }


            return dt;
        }

        public Escola selecionado(int id)
        {
            Escola escola = new Escola();
            MySqlDataReader reader;
            conexao.Close();
            conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT * FROM pnteduc.escola WHERE @id = escolaId", conexao);
                comando.Parameters.AddWithValue("@id", id);
                reader = comando.ExecuteReader();
                List<Escola> lista = new List<Escola>();
                while (reader.Read()) {
                    string idS = reader[0].ToString();
                    string nome = reader[1].ToString();

                    int idi = Int32.Parse(idS);
                    escola = new Escola(idi, nome);
                }
                
            }
            catch (Exception e)
            {

            }
            return escola;

        }

        public void salvar(Escola e )
        {
            comando = new MySqlCommand();
            comando.CommandText = "INSERT INTO escola (nomeEscola) VALUES (@nome)";


            comando.Parameters.AddWithValue("@nome", e.NomeEscola);
           

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
