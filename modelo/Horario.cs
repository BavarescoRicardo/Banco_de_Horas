using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto_Educacional.modelo
{
    class Horarios
    {
        

        private int id;     
        private int semana;
        private string hr;
        private string min;

        public Horarios()
        {

        }

        public Horarios(int semana, string hr, string min)
        {
            this.semana = semana;
            this.hr = hr;
            this.min = min;
        }

        public string getDiaSmn()
        {
            return this.semana.ToString();
        }

        public string getHr()
        {
            return this.hr;
        }

        public string getMin()
        {
            return this.min;
        }
        
    }
}
