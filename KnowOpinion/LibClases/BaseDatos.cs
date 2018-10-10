using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    class BaseDatos
    {
        private Usuario admin;
        private List<Encuesta> Lista_Encuestas = new List<Encuesta>();
        private static int ENCUESTA_COUNT = 0;

        private bool estaAuthed;
        public bool Autenticado
        {
            get { return estaAuthed; }
            set { estaAuthed = value; }
        }

        public BaseDatos()
        {
            this.admin = new Usuario("comandante666", "jofrillos");
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
            Lista_Encuestas.Add(new Encuesta(ENCUESTA_COUNT, titulo, des));
            ENCUESTA_COUNT += 1;
        }

        public Encuesta GetEncuestaById(int id)
        {
            return Lista_Encuestas[id];
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
            return estaAuthed;
        }

    }
}
