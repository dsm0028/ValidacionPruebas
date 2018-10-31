using LibClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace www
{
    public partial class Menu : System.Web.UI.Page
    {
        BaseDatos bd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            bd = (BaseDatos)Session["bd"];
            if (bd == null)
            {
                bd = new BaseDatos();
                Session["bd"] = bd;
            }

            if (bd.Autenticado)
            {
                Lbl_usuario.Text = "Bienvenido, " + bd.NombreAdmin;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}