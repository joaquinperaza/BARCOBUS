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
        {   encargado auth = (encargado)Session["auth"];
        if (auth==null)
        {
            label.Text = "Debe ingresar al sistema.";
        }
        else if (auth.Permisos < 2) {
                label.Text = "No cuenta con los permisos necesarios para completar la operacion.";
            }
        else try
        {
            tripulante t = new tripulante();
            t.Nombre = TextBox1.Text;
            t.Ci = Convert.ToInt32(TextBox2.Text);
            t.Rol = Convert.ToInt32(DropDownList1.SelectedValue);

            Global.b.createTripulante(t, auth);
            label.Text = "Creado!";
        }
        catch { label.Text = "Revise los campos de informacion."; }
        }

        
        
    }
}