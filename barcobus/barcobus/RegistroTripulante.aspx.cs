using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barcobus
{
    public partial class RegistroTripulante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tripulante t = new tripulante();
            t.Nombre = TextBox1.Text;
            t.Ci = Convert.ToInt32(TextBox2.Text);
            t.Rol = Convert.ToInt32(DropDownList1.SelectedValue);
            encargado auth = (encargado)Session["auth"];
            Global.b.createTripulante(t, auth);
        }

        
        
    }
}