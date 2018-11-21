using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barcobus
{
    public partial class crearMantenimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
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
                    mantenimiento m = new mantenimiento();
                    m.Codigo = Convert.ToInt32(TextBox1.Text);
                    m.Descripcion = TextBox2.Text;
                    m.PrecioBase = Convert.ToInt32(TextBox3.Text);
                    Global.b.createMantenimiento(m, auth);
                }
                catch { }
        }
    }
}