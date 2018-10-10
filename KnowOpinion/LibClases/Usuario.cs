using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace LibClases
{
	public class Usuario
	{

    private string Encriptar(string password)
    {
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
        SHA256 mySHA256 = SHA256.Create();
        bytes = mySHA256.ComputeHash(bytes);
        return (System.Text.Encoding.ASCII.GetString(bytes));
    }


    private string contrasena;
        public string Contrasena
        {
            get { return contrasena; }
            set { this.contrasena = value; }
        }

        public Usuario(string _cuenta)
		{
			this.cuenta = _cuenta;
			this.contrasena = Encriptar("");

		}
    
        public Usuario(string _cuenta, string _contrasena)
        {
            this.cuenta = _cuenta;
            this.contrasena = Encriptar(_contrasena);
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


        public bool comprobarcontrasena(string c)
        {
            string _c = Encriptar(c);
            return _c.Equals(this.contrasena);
        }

        public void asignacontrasena(string c)
        {
            string _c = Encriptar(c);
            this.contrasena = _c;
        }

        public bool cambiarcontrasenaantigua(string c, string nueva)
        {
            if (comprobarcontrasena(c) && Grabado)
            {
                asignacontrasena(nueva);
                return true;
            }
            return false;
        }

        public bool cambiarcontrasenanoguardada(string c)
        {
            if (!Grabado)
            {
                asignacontrasena(c);
                return true;
            }
            return false;
        }

        public void grabarcontrasena()
        {
            Grabado = true;
        }
    }
}
