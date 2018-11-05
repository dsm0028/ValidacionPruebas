using LibClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace www
{
    public partial class ADEncuesta : System.Web.UI.Page
    {
            BaseDatos bd = null;
            List<ListItem> encuestasTotales = new List<ListItem>();

            protected void Page_Load(object sender, EventArgs e)
            {
                bd = (BaseDatos)Session["bd"];

                if (!IsPostBack)
                {
                    Session["ModEncuesta"] = null;

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

                    DropDownList_SelecEncu.DataSource = encuestasTotales;
                    DropDownList_SelecEncu.DataBind();
                }
            }

        protected void Button_Aceptar_Click(object sender, EventArgs e)
        {
            bool changed = false;
            if (Session["ModEncuesta"] == null)
            {
                foreach (ListItem mod in DropDownList_SelecEncu.Items)
                {
                    if (mod.Selected)
                    {
                        if(CheckBox_Activar.Checked && CheckBox_Desactivar.Checked)
                        {
                            Lbl_err.Text = "Elija solo una opción.";
                            Lbl_err.Visible = true;
                            break;
                        }

                        if (CheckBox_Activar.Checked && !CheckBox_Desactivar.Checked)
                        {
                            bd.GetEncuestaByTitulo(mod.Value).Activa = true;
                            changed = true;
                            break;
                        }

                        if (!CheckBox_Activar.Checked && CheckBox_Desactivar.Checked)
                        {
                            bd.GetEncuestaByTitulo(mod.Value).Activa = false;
                            changed = true;
                            break;
                        }

                        if (!CheckBox_Activar.Checked && !CheckBox_Desactivar.Checked)
                        {
                            Lbl_err.Text = "No se ha elegido nada!";
                            Lbl_err.Visible = true;
                            break;
                        }
                    }

                }

                if (changed)
                {
                    Response.BufferOutput = true;
                    Response.Redirect("Menu.aspx");
                }

            }
        }
    }
}