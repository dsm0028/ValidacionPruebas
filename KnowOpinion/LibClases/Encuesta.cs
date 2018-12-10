using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class Encuesta
    {

        private int RESPUESTA_COUNT = 0;

        public Encuesta(int id, string tit, string des)
        {
            this.id = id;
            this.activa = true;
            this.titulo = tit;
            this.descripcion = des;
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

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

        public int NumRespuestas()
        {
            return lista_respuestas.Count;
        }

        public int NotaMaxima()
        {
            if(lista_respuestas.Count == 0)
            {
                return 0;
            }

            int maxima = 1;
            foreach(Respuesta r in lista_respuestas)
            {
                if(r.Valoracion > maxima)
                {
                    maxima = r.Valoracion;
                }
            }

            return maxima;
        }

        public void AnadirRespuesta(int val, string com)
        {
            RESPUESTA_COUNT += 1;
            lista_respuestas.Add(new Respuesta(RESPUESTA_COUNT,val,com, DateTime.Now));

        }

        public void AnadirRespuestaPersonalizada(int val, string com, DateTime f)
        {
            RESPUESTA_COUNT += 1;
            lista_respuestas.Add(new Respuesta(RESPUESTA_COUNT, val, com, f));

        }

        public List<Respuesta> ObtenerRespuestas()
        {
            return lista_respuestas;
        }

        public Respuesta ObtenerRespuestaPorId(int id)
        {
            foreach(Respuesta r in lista_respuestas)
            {
                if(r.Id == id)
                {
                    return r;
                }
            }
            return null;
        }

        public void QuitaRespuesta(int id)
        {
            lista_respuestas.Remove(ObtenerRespuestaPorId(id));
        }

        public override bool Equals(object obj)
        {
            Encuesta usu = obj as Encuesta;
            if (this.id == usu.id)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.id;

        }

    }
}
