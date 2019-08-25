using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Ponto_Educacional.modelo;

namespace Ponto_Educacional.bd
{
    class HorarioBD
    {
        
        private MySqlConnection conexao;
        private MySqlCommand comando = new MySqlCommand();
        private MySqlDataReader DR;
        private Conecta c;

        public HorarioBD()
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

        public void salvar(Horarios h)
        {
            comando.CommandText = "INSERT INTO horarios (diaSemana,hora,minuto) VALUES (@ds,@hr,@mn)";

            comando.Parameters.AddWithValue("@ds", h.getDiaSmn());
            comando.Parameters.AddWithValue("@hr", h.getHr());
            comando.Parameters.AddWithValue("@mn", h.getMin());

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
