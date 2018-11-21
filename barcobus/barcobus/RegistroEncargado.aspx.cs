using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barcobus
{
    public partial class RegistroEncargado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e2)
        {

        }

        protected void Button1_Click(object sender, EventArgs e2)
        {
            encargado e = new encargado();
            e.Nombre = TextBox1.Text;
            e.Ci = Convert.ToInt32(TextBox2.Text);
            e.PersonasACargo = Convert.ToInt32(TextBox3.Text);
            e.Permisos = Convert.ToInt32(DropDownList1.SelectedValue);
            e.Password = Global.b.CalculateMD5Hash(TextBox4.Text);
            encargado auth = (encargado)Session["auth"];
            Global.b.createEncargado(e, auth);
        }

        
        
    }
}