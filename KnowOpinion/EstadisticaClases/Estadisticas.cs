using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibClases;

namespace EstadisticaClases
{
    public class Estadisticas
    {
        private BaseDatos bd;

        public Estadisticas(BaseDatos bd)
        {
            this.bd = bd;
        }

        public int numeroEncuestas()
        {
            List<Encuesta> lista = bd.ObtenerTodas();
            int contador = 0;
            foreach(Encuesta e in lista)
            {
                List<Respuesta> r = e.ObtenerRespuestas();
                if (r.Count > 0)
                {
                    contador++;
                }
            }
            return contador;
        }

        public DataTable estadoEncuestas()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Estado", typeof(string));
            tabla.Columns.Add("Numero", typeof(int));

            tabla.Rows.Add("Activas", bd.ObtenerActivas().Count);
            tabla.Rows.Add("Inactivas", bd.ObtenerTodas().Count - bd.ObtenerActivas().Count);

            return tabla;
        }

        public double media()
        {
            double sumatorio = 0.0;
            double numeroRespuestas = 0.0;
            List<Encuesta> lista = bd.ObtenerTodas();
            foreach(Encuesta e in lista)
            {
                foreach(Respuesta r in e.ObtenerRespuestas())
                {
                    sumatorio += r.Valoracion;
                    numeroRespuestas++;
                }
            }

            return sumatorio / numeroRespuestas;

        }

        public double mediana()
        {
            List<int> vals = new List<int>();
            List<Encuesta> lista = bd.ObtenerTodas();

            foreach (Encuesta e in lista)
            {
                foreach (Respuesta r in e.ObtenerRespuestas())
                {
                    vals.Add(r.Valoracion);
                }
            }

            vals.Sort();

            int midpoint = vals.Count();
            if(midpoint % 2 != 0)
            {
                return vals[(midpoint / 2) - 1];
            } else
            {
                double half = (midpoint / 2) - 1;
                double t = vals[(int)Math.Round(half)] + vals[(int)Math.Round(half) + 1];
                return t / 2;
            }

        }

        public double desvest()
        {
            List<int> vals = new List<int>();
            List<Encuesta> lista = bd.ObtenerTodas();

            foreach (Encuesta e in lista)
            {
                foreach (Respuesta r in e.ObtenerRespuestas())
                {
                    vals.Add(r.Valoracion);
                }
            }

            double med = media();
            double varianza = 0.0;
            
            foreach(int i in vals)
            {
                varianza += Math.Pow(Convert.ToDouble(i) - med, 2);
            }

            return Math.Sqrt(varianza / (vals.Count - 1));

        }

        public DataTable rankingEncuestasPorRespuestas()
        {
            List<Encuesta> lista = bd.ObtenerTodas();
            DataTable t = new DataTable();

            t.Columns.Add("Titulo de la encuesta", typeof(string));
            t.Columns.Add("Respuestas recibidas", typeof(int));
            
            foreach(Encuesta e in lista)
            {
                t.Rows.Add(e.Titulo, e.NumRespuestas());
            }

            DataView dv = t.DefaultView;
            dv.Sort = "Respuestas recibidas DESC";
            return dv.ToTable();

        }

        public DataTable rankingEncuestasPorValoracion()
        {
            List<Encuesta> lista = bd.ObtenerTodas();
            DataTable t = new DataTable();

            t.Columns.Add("Titulo de la encuesta", typeof(string));
            t.Columns.Add("Nota Maxima", typeof(int));

            foreach (Encuesta e in lista)
            {
                t.Rows.Add(e.Titulo, e.NotaMaxima());
            }

            DataView dv = t.DefaultView;
            dv.Sort = "Nota Maxima DESC";
            return dv.ToTable();

        }
    }
}
