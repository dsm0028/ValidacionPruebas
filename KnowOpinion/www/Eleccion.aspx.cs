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
        Encuesta activas;
        int valoracion;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                BaseDatos bd = (BaseDatos)Session["bd"];
                activas = null;

                if (bd == null)
                {
                    bd = new BaseDatos();
                    Session["bd"] = bd;
                }

                if (Session["val"] == null)
                {
                    Session["val"] = 0;
                }

                if (Session["Encuesta"] != null)
                {
                    activas = (Encuesta)Session["Encuesta"];
                }

                foreach (Encuesta en in bd.ObtenerActivas())
                {
                    encuestasActivas.Add(new ListItem(en.Titulo + " - " + en.Descripcion, (en.Id).ToString()));
                }

                SeleccionarEncuesta.DataSource = encuestasActivas;
                SeleccionarEncuesta.DataBind();
            }
        }


        protected void ImageButton_Triste_Click(object sender, ImageClickEventArgs e)
        {
            Session["val"] = 2;
            Lbl_valoracion.Text = "Valoracion actual: " + Session["val"].ToString();
        }

        protected void ImageButton_Enfadado_Click(object sender, ImageClickEventArgs e)
        {
            Session["val"] = 1;
            Lbl_valoracion.Text = "Valoracion actual: " + Session["val"].ToString();
        }

        protected void ImageButton_Contento_Click(object sender, ImageClickEventArgs e)
        {
            Session["val"] = 3;
            Lbl_valoracion.Text = "Valoracion actual: " + Session["val"].ToString();
        }

        protected void ImageButton_Enamorado_Click(object sender, ImageClickEventArgs e)
        {
            Session["val"] = 4;
            Lbl_valoracion.Text = "Valoracion actual: " + Session["val"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("Login.aspx");
        }

        protected void Button_Enviar_Click(object sender, EventArgs e)
        {
            string[] sep = new string[] { " - " };
            if ((int)Session["val"] != 0)
            {
                foreach (ListItem j in SeleccionarEncuesta.Items)
                {
                    if (j.Value == SeleccionarEncuesta.SelectedValue)
                    {
                        string s = j.Value.Split(sep, StringSplitOptions.None)[0];
                        BaseDatos bd = (BaseDatos)Session["bd"];
                        Encuesta enc = bd.GetEncuestaByTitulo(s);
                        enc.AnadirRespuesta((int)Session["val"], TextBox1.Text);
                        Lbl_ok.Visible = true;
                        Lbl_ok.Text = "Se ha enviado correctamente";
                        
                        break;
                        
                    }
                }
                
            }
            else
            {
                Lbl_ok.Visible = true;
                Lbl_ok.Text = "Error! Seleccione una valoración";
            }
            
            
        }
    }
}