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
            else
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("AltaEncuesta.aspx");
        }

        protected void Button_BorrarEncuesta_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("BorrarEncuesta.aspx");
        }

        protected void Button_ModificarEncuesta_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("ModificarEncuesta.aspx");
        }

        protected void Button_ADEncuesta_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("ADEncuesta.aspx");
        }

        protected void Button_CerrarSesion_Click(object sender, EventArgs e)
        {
            bd.Logoff();
            Response.BufferOutput = true;
            Response.Redirect("Login.aspx");
        }
    }
}