using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class BaseDatos
    {
        private Usuario admin;
        private List<Encuesta> Lista_Encuestas = new List<Encuesta>();
        private int ENCUESTA_COUNT = 0;
        
        public string NombreAdmin
        {
            get { return admin.Nombre + " " + admin.Apellido;  }
        }

        private bool estaAuthed;
        public bool Autenticado
        {
            get { return estaAuthed; }
            set { estaAuthed = value; }
        }

        public BaseDatos()
        {
            this.admin = new Usuario("comandante666", "jofrillos");
            this.admin.Nombre = "Fernando";
            this.admin.Apellido = "Fernandoso";
            ENCUESTA_COUNT += 1;
            this.Lista_Encuestas.Add(new Encuesta(ENCUESTA_COUNT, "Prueba 1", "Descripcion de prueba 1"));
            this.Lista_Encuestas.Add(new Encuesta(ENCUESTA_COUNT, "Prueba 2", "Descripcion de prueba 2"));
            this.Lista_Encuestas.Add(new Encuesta(ENCUESTA_COUNT, "Prueba 3", "Descripcion de prueba 3"));
        }



        public List<Encuesta> ObtenerActivas()
        {
            List<Encuesta> activas = new List<Encuesta>();
            foreach (Encuesta e in Lista_Encuestas)
            {
                if (e.Activa)
                {
                    activas.Add(e);
                }
            }
            return activas;
        }

        public List<Encuesta> ObtenerTodas()
        {
            return Lista_Encuestas;
        }

        public void AddEncuesta(string titulo, string des)
        {
            ENCUESTA_COUNT += 1;
            Lista_Encuestas.Add(new Encuesta(ENCUESTA_COUNT, titulo, des));
        }

        public Encuesta GetEncuestaById(int id)
        {
            foreach (Encuesta e in Lista_Encuestas)
            {
                if (e.Id == id)
                {
                    return e;
                }
            }
            return null;
        }

        public Encuesta GetEncuestaByTitulo(string t)
        {
            foreach(Encuesta e in Lista_Encuestas)
            {
                if (e.Titulo.Equals(t)){
                    return e;
                }
            }
            return null;
        }

        public void BorraEncuesta(string titulo)
        {
            Lista_Encuestas.Remove(GetEncuestaByTitulo(titulo));
        }

        public void AnadirRespuesta(Encuesta e, int valora, string comenta)
        {
            e.AnadirRespuesta(valora, comenta);
        }

        public void ActualizaRespuesta(int encuestaId, int respuestaId, int nueva_val, string nueva_des)
        {
            Respuesta a = GetEncuestaById(encuestaId).ObtenerRespuestaPorId(respuestaId);
            if (nueva_val >= 1 && nueva_val <= 4)
            {
                a.Valoracion = nueva_val;
            }

            if (nueva_des != null)
            {
                a.Descripcion = nueva_des;
            }
        }

        public void BorraRespuesta(int encuestaId, int respuestaId)
        {
            GetEncuestaById(encuestaId).QuitaRespuesta(respuestaId);
        }

        public bool Login(string user, string p)
        {
            
            if(admin.Cuenta.Equals(user) && admin.comprobarcontrasena(p))
            {
                estaAuthed = true;
            }
            return estaAuthed;
        }

        public bool Logoff()
        {
            estaAuthed = false;
            return !estaAuthed;
        }

    }
}
