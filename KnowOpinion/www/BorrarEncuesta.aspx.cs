using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibClases;

namespace www
{
    public partial class BorrarEncuesta : System.Web.UI.Page
    {
        BaseDatos bd = null;
        List<ListItem> encuestasTotales = new List<ListItem>();

        protected void Page_Load(object sender, EventArgs e)
        {
            bd = (BaseDatos)Session["bd"];

            if (!IsPostBack)
            {
                Session["BorrarEncuesta"] = null;

                bd = (BaseDatos)Session["bd"];
                if (bd == null)
                {
                    bd = new BaseDatos();
                    Session["bd"] = bd;
                }

                foreach (Encuesta en in bd.ObtenerTodas())
                {
                    encuestasTotales.Add(new ListItem(en.Titulo, (en.Id).ToString()));
                }
                
                Seleccionar_BorrarEncuesta.DataSource = encuestasTotales;
                Seleccionar_BorrarEncuesta.DataBind();
            }
        }

        protected void Button_Aceptar_Click(object sender, EventArgs e)
        {
            
            if (Session["BorrarEncuesta"] == null)
            {
                foreach (ListItem borrar in Seleccionar_BorrarEncuesta.Items)
                {
                    if (borrar.Selected)
                    {
                        bd.BorraEncuesta(borrar.Text);
                        Response.BufferOutput = true;
                        Response.Redirect("Menu.aspx");
                        break;
                    }

                }
                 
            }
            else
            {
                Lbl_ErrorBorrar.Text = "Error! No se ha borrado la encuesta";
            }
            
        }
    }
}