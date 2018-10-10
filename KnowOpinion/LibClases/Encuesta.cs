using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class Encuesta
    {
        private bool activa;
        public bool Activa
        {
            get { return activa; }
            set { this.activa = value; }
        }

        private string titulo;
        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        private List<Respuesta> lista_respuestas = new List<Respuesta>();

        public List<Respuesta> ObtenerRespuestas()
        {
            return lista_respuestas;
        }

        public void AnadirRespuesta(Respuesta e)
        {

            lista_respuestas.Add(e);

        }

    }
}
