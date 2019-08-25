using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco_de_Horas.conexao;
using MySql.Data.MySqlClient;
using Banco_de_Horas.modelo;
using System.Data;

namespace Bancod_de_Horas.bd
{
    class ExtraBd
    {
        
        private MySqlConnection conexao;
        private MySqlCommand comando = new MySqlCommand();
        private MySqlDataReader DR;
        private Conecta c;

        public ExtraBd()
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

        public void salvar(Extra e)
        {
            comando.CommandText = "INSERT INTO bancohoras.extra (quantidadeH,quantidadeMin,dia,observacao,funcionarioFk)"+
                " VALUES (@hr,@mn,@dia,@obs,@func)";

            comando.Parameters.AddWithValue("@hr",e.ExtraHora);
            comando.Parameters.AddWithValue("@mn",e.ExtraMin);
            comando.Parameters.AddWithValue("@dia",e.Dia);
            comando.Parameters.AddWithValue("@obs",e.Observacao);
            comando.Parameters.AddWithValue("@func",e.Funcionario.Matricula);

            try
            {
                comando.Connection = c.inicia();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
                     
          
        }

        public DataTable listar(int fk)
        {

            DataTable dt = new DataTable();
  
            MySqlDataReader reader;
            conexao.Close();
            conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT * FROM bancohoras.extra WHERE @f = funcionarioFk", conexao);
                comando.Parameters.AddWithValue("@f", fk);
                reader = comando.ExecuteReader();

                dt.Load(reader);

            }
            catch (Exception)
            {

            }


            return dt;
        }

    }

}
