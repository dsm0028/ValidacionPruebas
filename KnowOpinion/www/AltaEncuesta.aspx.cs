using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace www
{
    public partial class AltaEncuesta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Aceptar_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("Menu.aspx");
        }
    }
}