using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    class BaseDatos
    {
        private List<Usuario> Lista_Usuarios = new List<Usuario>();
        private List<Encuesta> Lista_Encuestas = new List<Encuesta>();
        private Usuario u_auth;
        public Usuario Usuario_autenticado
        {
            get { return u_auth; }
            set { this.u_auth = value; }
        }

        public BaseDatos()
        {
            this.Usuario_autenticado = null;
            
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

    }
}
