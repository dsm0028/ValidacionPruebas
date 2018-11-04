using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibClases;

namespace www
{
    public partial class ModificarEncuesta : System.Web.UI.Page
    {
        BaseDatos bd = null;
        List<ListItem> encuestasTotales = new List<ListItem>();

        protected void Page_Load(object sender, EventArgs e)
        {
            bd = (BaseDatos)Session["bd"];

            if (!IsPostBack)
            {
                Session["ModificarEncuesta"] = null;

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

                Seleccionar_ModificarEncuesta.DataSource = encuestasTotales;
                Seleccionar_ModificarEncuesta.DataBind();
            }

        }

        protected void Button_A_Click(object sender, EventArgs e)
        {
            if (Session["ModificarEncuesta"] == null)
            {
                foreach (ListItem modificar in Seleccionar_ModificarEncuesta.Items)
                {
                    if (modificar.Selected)
                    {
                        //Modificacion pendiente 
                        Response.BufferOutput = true;
                        Response.Redirect("Menu.aspx");
                        break;
                    }

                }

            }
            else
            {
                Lbl_ErrorModificar.Text = "Error! No se ha modificado la encuesta";
            }
        }
    }
}