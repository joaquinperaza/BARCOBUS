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
            encargado auth = (encargado)Session["auth"];
            if (auth==null)
        {
            label.Text = "Debe ingresar al sistema.";
        }
        else if (auth.Permisos < 3)
            {
                label.Text = "No cuenta con los permisos necesarios para completar la operacion.";
            }
            else try
            {
                encargado e = new encargado();
                e.Nombre = TextBox1.Text;
                e.Ci = Convert.ToInt32(TextBox2.Text);
                e.PersonasACargo = Convert.ToInt32(TextBox3.Text);
                e.Permisos = Convert.ToInt32(DropDownList1.SelectedValue);
                e.Password = Global.b.CalculateMD5Hash(TextBox4.Text);
                Global.b.createEncargado(e, auth);
            }
            catch { label.Text = "Revise los campos de informacion."; }
        }

        
        
    }
}