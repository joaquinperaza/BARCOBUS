using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barcobus
{
    public partial class altaReparacion : System.Web.UI.Page
    {
        List<barco> bl;
        protected void Page_Load(object sender, EventArgs e)
        {
            bl = Global.b.barcoList();
            DropDownList1.DataSource = bl;
            
            if (!IsPostBack)
            {
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            encargado auth = (encargado)Session["auth"];
            if (auth == null)
            {
                label.Text = "Debe ingresar al sistema.";
            }
            else if (auth.Permisos < 1)
            {
                label.Text = "No cuenta con los permisos necesarios para completar la operacion.";
                registroReparacion rr = new registroReparacion();
                rr.Reparacion = TextBox1.Text;
                rr.Descripcion = TextBox2.Text;
                rr.Encargado = auth;
                Global.b.registrarReparacion(rr, DropDownList1.SelectedItem.Text, auth);
            }
            else try
                {
                    registroReparacion rr = new registroReparacion();
                    rr.Reparacion = TextBox1.Text;
                    rr.Descripcion = TextBox2.Text;
                    rr.Encargado = auth;
                    Global.b.registrarReparacion(rr, DropDownList1.SelectedItem.Text, auth);
                    label.Text = "Registro creado!";
                    
                }
                catch { }
        }

       
    }
}