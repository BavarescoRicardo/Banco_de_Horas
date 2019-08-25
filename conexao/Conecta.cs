using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Banco_de_Horas.conexao

{
    public class Conecta
    {
        
        private MySqlConnection conexao;

        public Conecta()
        {
            
        }

        public MySqlConnection inicia()
        {
            conexao = new MySqlConnection("Server=localhost; Database=bancohoras; Uid=root; Pwd=admin");
            try
            {
                if (conexao.State == System.Data.ConnectionState.Closed)
                conexao.Open();
            }
            catch (Exception e)
            {

            }
            return conexao;
        }
        
    }
}
