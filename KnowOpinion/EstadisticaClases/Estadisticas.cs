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
            if(numeroRespuestas == 0.0)
            {
                return 0.0;
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

            if(vals.Count == 0)
            {
                return 0.0;
            }

            vals.Sort();

            int midpoint = vals.Count();
            if(midpoint % 2 != 0)
            {
                return vals[(midpoint / 2)];
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

            if (vals.Count <= 1)
            {
                return 0.0;
            }

            double med = media();
            double varianza = 0.0;
            
            foreach(int i in vals)
            {
                varianza += Math.Pow(Convert.ToDouble(i) - med, 2);
            }

            return Math.Sqrt(varianza / (vals.Count - 1));

        }

        private List<Respuesta> recolectarTodas()
        {
            List<Respuesta> l = new List<Respuesta>();
            foreach(Encuesta e in bd.ObtenerTodas())
            {
                foreach(Respuesta r in e.ObtenerRespuestas())
                {
                    l.Add(r);
                }
            }
            return l;
        }

        public DataTable respuestasPorSemanas()
        {
            List<Respuesta> res = recolectarTodas();

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Dia de la semana", typeof(string));
            tabla.Columns.Add("Numero", typeof(int));

            for(int i = 10; i < 17; i++)
            {
                string diaSemana = new DateTime(2018, 12, i).ToString("dddd");
                tabla.Rows.Add(diaSemana, 0);
            }

            foreach(Respuesta r in res)
            {
                DateTime f = r.Fecha;
                int currval =(int) tabla.Rows[(int)f.DayOfWeek]["Numero"];
                tabla.Rows[(int)f.DayOfWeek]["Numero"] = currval + 1;
            }

            return tabla;
        }

        public DataTable respuestasPorMeses()
        {
            List<Respuesta> res = recolectarTodas();

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Mes", typeof(string));
            tabla.Columns.Add("Numero", typeof(int));

            for (int i = 1; i < 13; i++)
            {
                string mes = new DateTime(2018, i, 1).ToString("MMMM");
                tabla.Rows.Add(mes, 0);
            }

            foreach (Respuesta r in res)
            {
                DateTime f = r.Fecha;
                int currval = (int)tabla.Rows[f.Month - 1]["Numero"];
                tabla.Rows[f.Month - 1]["Numero"] = currval + 1;
            }

            return tabla;

        }

        public DataTable respuestasPorAnios()
        {
            List<Respuesta> res = recolectarTodas();

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Año", typeof(int));
            tabla.Columns.Add("Numero", typeof(int));

            int anoMenor = DateTime.Now.Year;
            int anoMayor = 0;
            
            foreach(Respuesta r in res)
            {
                if(r.Fecha.Year < anoMenor)
                {
                    anoMenor = r.Fecha.Year;
                }
                if(r.Fecha.Year > anoMayor)
                {
                    anoMayor = r.Fecha.Year;
                }

            }

            for(int i = anoMenor; i <= anoMayor; i++)
            {
                tabla.Rows.Add(i, 0);
            }

            foreach (Respuesta r in res)
            {
                DateTime f = r.Fecha;
                int currval = (int)tabla.Rows[f.Year - anoMenor]["Numero"];
                tabla.Rows[f.Year - anoMenor]["Numero"] = currval + 1;
            }

            return tabla;
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

        public DataTable mediaPorEncuesta()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Titulo de la encuesta", typeof(string));
            tabla.Columns.Add("Media", typeof(double));

            List<Encuesta> lista = bd.ObtenerTodas();
            foreach (Encuesta e in lista)
            {
                double sumatorio = 0.0;
                double numeroRespuestas = 0.0;
                foreach (Respuesta r in e.ObtenerRespuestas())
                {
                    sumatorio += r.Valoracion;
                    numeroRespuestas++;
                }

                if(numeroRespuestas == 0)
                {
                    tabla.Rows.Add(e.Titulo, 0.0);
                    continue;
                }

                tabla.Rows.Add(e.Titulo, sumatorio / numeroRespuestas);

            }

            DataView dv = tabla.DefaultView;
            dv.Sort = "Media DESC";
            return dv.ToTable();
        }

        public DataTable respuestasPorHoras()
        {
            List<Respuesta> res = recolectarTodas();

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Franja horaria", typeof(int));
            tabla.Columns.Add("Numero", typeof(int));

            for (int i = 0; i < 25; i++)
            {
                tabla.Rows.Add(i, 0);
            }

            foreach (Respuesta r in res)
            {
                DateTime f = r.Fecha;
                int currval = (int)tabla.Rows[f.Hour]["Numero"];
                tabla.Rows[f.Hour]["Numero"] = currval + 1;
            }

            return tabla;
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

        public DataTable desvEstPorEncuesta()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Titulo de la encuesta", typeof(string));
            tabla.Columns.Add("Desviacion", typeof(double));

            List<Encuesta> lista = bd.ObtenerTodas();
            foreach(Encuesta e in lista)
            {
                List<int> vals = new List<int>();
                double sumat = 0.0;
                foreach (Respuesta r in e.ObtenerRespuestas())
                {
                    vals.Add(r.Valoracion);
                    sumat += r.Valoracion;
                }
                if (vals.Count <= 1)
                {
                    tabla.Rows.Add(e.Titulo, 0.0);
                    continue;
                }

                double med = sumat / vals.Count;
                double varianza = 0.0;

                foreach (int i in vals)
                {
                    varianza += Math.Pow(Convert.ToDouble(i) - med, 2);
                }

                tabla.Rows.Add(e.Titulo, Math.Sqrt(varianza / (vals.Count - 1)));
            }

            DataView dv = tabla.DefaultView;
            dv.Sort = "Desviacion DESC";
            return dv.ToTable();
        }

        public DataTable medianaPorEncuesta()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Titulo de la encuesta", typeof(string));
            tabla.Columns.Add("Mediana", typeof(double));

            List<Encuesta> lista = bd.ObtenerTodas();
            foreach(Encuesta e in lista){
                List<int> vals = new List<int>();
                foreach(Respuesta r in e.ObtenerRespuestas())
                {
                    vals.Add(r.Valoracion);
                }

                if (vals.Count == 0)
                {
                    tabla.Rows.Add(e.Titulo, 0.0);
                    continue;
                }

                vals.Sort();

                int midpoint = vals.Count();
                if (midpoint % 2 != 0)
                {
                    tabla.Rows.Add(e.Titulo, vals[(midpoint / 2)]);
                }
                else
                {
                    double half = (midpoint / 2) - 1;
                    double t = vals[(int)Math.Round(half)] + vals[(int)Math.Round(half) + 1];
                    tabla.Rows.Add(e.Titulo, t / 2);
                }

            }

            DataView dv = tabla.DefaultView;
            dv.Sort = "Mediana DESC";
            return dv.ToTable();
        }

        public DataTable numRespRangosPorEncuesta(int v)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Titulo", typeof(string));
            tabla.Columns.Add("Menor valoracion", typeof(int));
            tabla.Columns.Add("Mayor valoracion", typeof(int));
            Encuesta e = bd.GetEncuestaById(v);
            int min = 99;
            int max = -1;

            foreach(Respuesta r in e.ObtenerRespuestas())
            {
                if(r.Valoracion < min)
                {
                    min = r.Valoracion;
                }

                if (r.Valoracion > max)
                {
                    max = r.Valoracion;
                }
            }

            tabla.Rows.Add(e.Titulo, min, max);
            return tabla;
        }

        public DataTable numRespRangos()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Titulo", typeof(string));
            tabla.Columns.Add("Menor valoracion", typeof(int));
            tabla.Columns.Add("Mayor valoracion", typeof(int));
            List<Encuesta> lista = bd.ObtenerTodas();

            foreach(Encuesta e in lista)
            {
                DataRow fila = numRespRangosPorEncuesta(e.Id).Rows[0];
                tabla.Rows.Add(fila[0], fila[1], fila[2]);
            }

            return tabla;
        }
    }
}
