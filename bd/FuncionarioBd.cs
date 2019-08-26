using MySql.Data.MySqlClient;
using Bancod_de_Horas.modelo;
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
using Bancod_de_Horas.modelo;

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

        
        // SELECT * FROM bancohoras.funcionario WHERE nome LIKE 'r%';

        public DataTable pesquisa(string nome)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nome");
            dt.Columns.Add("cqrgo");
            dt.Columns.Add("ativo");
            dt.Columns.Add("setorfk");

            MySqlDataReader reader;
            conexao.Close();
            conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT * FROM bancohoras.funcionario WHERE nome LIKE @nome;", conexao);
                comando.Parameters.AddWithValue("@nome", nome+"%");
                reader = comando.ExecuteReader();

                dt.Load(reader);

            }
            catch (Exception e)
            {

            }


            return dt;
        }

        public Funcionario escolhido(int matricula)
        {
            Funcionario funcionario = new Funcionario();
            MySqlDataReader reader;
            conexao.Close();
            conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT * FROM bancohoras.funcionario WHERE @id = id", conexao);
                comando.Parameters.AddWithValue("@id", matricula);
                reader = comando.ExecuteReader();
                List<Funcionario> lista = new List<Funcionario>();
                string nome = "0";
                string cargo = "0";
                string ativo = "0";
                string setorS = "0";
                while (reader.Read())
                {
                    
                    nome = reader[1].ToString();
                    cargo = reader[2].ToString(); 
                    ativo = reader[3].ToString();
                    setorS = reader[4].ToString();

                }
                int ativoInteiro = Int32.Parse(ativo);
                int setorFk = Int32.Parse(setorS);

                SetorBd setorBd = new SetorBd();
                Setor setor = setorBd.selecionado(setorFk);

                funcionario = new Funcionario(matricula,nome,cargo,ativoInteiro,setor);
                

            }
            catch (Exception e)
            {

            }
            return funcionario;

        }


        public void salvar(Funcionario f )
        {
            comando = new MySqlCommand();
            comando.CommandText = "INSERT INTO bancohoras.funcionario (id, nome, cargo, ativo, setorfk) VALUES" +
                "(@cod, @nome, @cargo, @ativo, @setor);";

            comando.Parameters.AddWithValue("@cod",f.Matricula);
            comando.Parameters.AddWithValue("@nome", f.NomeFuncionario);
            comando.Parameters.AddWithValue("@cargo",f.Cargo);
            comando.Parameters.AddWithValue("@ativo",f.Ativo);
            comando.Parameters.AddWithValue("@setor",f.Setor.IdSetor);

            try
            {
                comando.Connection = c.inicia();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel salvar no banco");
            }

        }


    }

    
    
}
