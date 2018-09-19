using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
	class Usuario
	{

		private string contrasena;

		Usuario(string _cuenta)
		{
			this.cuenta = _cuenta;
			this.contrasena = "";

		}

		private string cuenta;
		public string Cuenta
		{
			get { return cuenta; }
			set { this.cuenta = value; }
		}
	}
}
