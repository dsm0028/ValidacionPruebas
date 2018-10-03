using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
	public class Usuario
	{

		private string contrasena;

		public Usuario(string _cuenta)
		{
			this.cuenta = _cuenta;
			this.contrasena = "";

		}

        public Usuario(string _cuenta, string _contrasena)
        {
            this.cuenta = _cuenta;
            this.contrasena = _contrasena;

        }

        private string cuenta;
		public string Cuenta
		{
			get { return cuenta; }
			set { this.cuenta = value; }
		}

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }

        private string apellido;
        public string Apellido
        {
            get { return apellido; }
            set { this.apellido = value; }
        }

        private string correo;
        public string Correo
        {
            get { return correo; }
            set { this.correo = value; }
        }

        private string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { this.direccion = value; }
        }

        private int c_postal;
        public int C_postal
        {
            get { return c_postal; }
            set { this.c_postal = value; }
        }

        private string localidad;
        public string Localidad
        {
            get { return localidad; }
            set { this.localidad = value; }
        }

        private bool grabado;
        public bool Grabado
        {
            get { return grabado; }
            set { this.grabado = value; }
        }


    }
}
