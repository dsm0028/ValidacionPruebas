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

                if (!bd.Autenticado)
                {
                    Response.Redirect("Login.aspx");
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
            bool changed = false;
            bool fail = true;
            if (Session["ModificarEncuesta"] == null)
            {
                foreach (ListItem modificar in Seleccionar_ModificarEncuesta.Items)
                {
                    if (modificar.Value == Seleccionar_ModificarEncuesta.SelectedValue)
                    {
                        fail = false;
                        BaseDatos bd = (BaseDatos)Session["bd"];
                        Encuesta enc = bd.GetEncuestaByTitulo(modificar.Value);
                        if (TextBox_NuevoT.Text.Length > 0) { 
                            enc.Titulo = TextBox_NuevoT.Text;
                            changed = true;
                        }

                        if (Tb_NuevaD.Text.Length > 0)
                        {
                            enc.Descripcion = Tb_NuevaD.Text;
                            changed = true;
                        }

                        if (!changed)
                        {
                            Lbl_ErrorModificar.Text = "No se ha modificado nada.";
                            Lbl_ErrorModificar.Visible = true;
                        }
                        else
                        {
                            Response.BufferOutput = true;
                            Response.Redirect("Menu.aspx");
                        }
                        break;
                    }

                }
                if (fail)
                {
                    Lbl_ErrorModificar.Text = "Error!";
                    Lbl_ErrorModificar.Visible = true;
                }

            }
            else
            {
                Lbl_ErrorModificar.Text = "Error! No se ha modificado la encuesta";
            }
        }
    }
}