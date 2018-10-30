using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibClases;

namespace www
{
    public partial class Eleccion : System.Web.UI.Page
    {
        List<ListItem> encuestasActivas = new List<ListItem>();
        BaseDatos bd = new BaseDatos();
        Encuesta activas;

        protected void Page_Load(object sender, EventArgs e)
        {
            activas = null;
            bd = (BaseDatos)Session["bd"];
            if(bd == null)
            {
                bd = new BaseDatos();
                Session["bd"] = bd;

                foreach(Encuesta en in bd.ObtenerActivas())
                {
                    encuestasActivas.Add(new ListItem(en.Titulo, (en.Id).ToString()));
                }

                SeleccionarEncuesta.DataSource = encuestasActivas;
                SeleccionarEncuesta.DataBind();

                if (Session["Encuesta"] != null)
                {
                    activas = (Encuesta)Session["Encuesta"];
                }
            }
        }

        protected void ImageButton_Triste_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton_Enfadado_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("Login.aspx");
        }
    }
}