using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barcobus
{
    public partial class RegistroBarcos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            encargado auth = (encargado)Session["auth"];
            if (auth == null)
            {
                label.Text = "Debe ingresar al sistema.";
            }
            else if (auth.Permisos < 2) {
                label.Text = "No cuenta con los permisos necesarios para completar la operacion.";
            }
            else try
            {
                if (RadioButtonList1.SelectedItem.Text == "Barco lento")
                {
                    barcoLento b = new barcoLento();
                    b.Nombre = TextBox1.Text;
                    b.CapacidadPasajeros = Convert.ToInt32(TextBox2.Text);
                    b.CapacidadTripulantes = Convert.ToInt32(TextBox3.Text);
                    b.CapacidadBodega = Convert.ToInt32(TextBox4.Text);
                    b.Adicional = Convert.ToInt32(TextBox5.Text);
                    Global.b.createBarco(b, auth);
                    label.Text = "Creado!";

                }
                else
                {
                    barcoRapido b = new barcoRapido();
                    b.Nombre = TextBox1.Text;
                    b.CapacidadPasajeros = Convert.ToInt32(TextBox2.Text);
                    b.CapacidadTripulantes = Convert.ToInt32(TextBox3.Text);
                    b.VelocidadMax = Convert.ToInt32(TextBox4.Text);
                    Global.b.createBarco(b, auth);
                    label.Text = "Creado!";
                }
            }
            catch {
                label.Text = "Revise los campos de informacion.";
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedItem.Text == "Barco lento")
            {
                Label1.Text = "Capacidad bodega";
                TextBox5.Enabled = true;
            }
            else {
                Label1.Text = "Velocidad maxima";
                TextBox5.Enabled = false;
            }
        }

        
    }
}