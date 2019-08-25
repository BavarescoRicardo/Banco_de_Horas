using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ponto_Educacional.bd
{
    public class Conecta
    {
        
        private MySqlConnection conexao;

        public Conecta()
        {
            
        }

        public MySqlConnection inicia()
        {
            conexao = new MySqlConnection("Server=localhost; Database=pntEduc; Uid=root; Pwd=admin");
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
