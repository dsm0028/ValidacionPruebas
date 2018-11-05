using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibClases;

namespace www
{
    public partial class AltaEncuesta : System.Web.UI.Page
    {
        BaseDatos bd = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            bd = (BaseDatos)Session["bd"];

            if (!IsPostBack)
            {
                Session["AltaEncuesta"] = null;

               bd = (BaseDatos)Session["bd"];
                if (bd == null)
                {
                    bd = new BaseDatos();
                    Session["bd"] = bd;
                }
                if (!bd.Autenticado)
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void Button_Aceptar_Click(object sender, EventArgs e)
        {
            if (Session["AltaEncuesta"] == null)
            {
                bd.AddEncuesta(TBox_NombreEncuesta.Text, TBox_Descripcion.Text);
                Lbl_AltaOk.Text = "Se ha dado de alta la encuesta correctamente";
                Response.BufferOutput = true;
                Response.Redirect("Menu.aspx");
            }
            else
            {
                Lbl_AltaFallido.Text = "Error! No se ha podido dar de alta la encuesta";
            }
            
            
        }
    }
}