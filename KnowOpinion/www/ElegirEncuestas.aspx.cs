using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibClases;

namespace www
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        BaseDatos bd = new BaseDatos(); //solo para pruebas!!

        protected void Page_Load(object sender, EventArgs e)
        {
            foreach(Encuesta en in bd.ObtenerActivas())
            {
                Desp_encuestas.Items.Add(new ListItem(en.Titulo, (en.Id).ToString()));
            }
            Desp_encuestas.DataBind();
        }
    }
}