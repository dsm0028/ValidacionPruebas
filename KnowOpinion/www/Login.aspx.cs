using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibClases;

namespace www
{
    public partial class PaginaWeb : System.Web.UI.Page
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
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            if(bd.Login(Tbox_usuario.Text, Tbx_contraseña.Text))
            {
                Label_ErrorLogin.Text = "";
                Response.BufferOutput = true;
                Response.Redirect("Menu.aspx");
            }
            else
            {
                Label_ErrorLogin.Text = "Error! Usuario o contraseña incorrectos";
            }

        }
    }
}