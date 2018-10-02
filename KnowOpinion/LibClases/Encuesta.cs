using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class Encuesta
    {
        private string num_encuesta;
        public string Num_encuesta
        {
            get { return num_encuesta; }
            set { this.num_encuesta = value; }
        }

        private int valoracion;
        public int Valoracion
        {
            get { return valoracion; }
            set { if (value >= 1 && value <= 4) 
                {
                    this.valoracion = value;
                }
            }
        }
        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { this.descripcion = value; }
        }


    }
}
