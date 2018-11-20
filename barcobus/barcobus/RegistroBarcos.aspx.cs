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
            if (RadioButtonList1.SelectedItem.Text == "Barco lento")
            {
                barcoLento b = new barcoLento();
                b.Nombre = TextBox1.Text;
                b.CapacidadPasajeros = Convert.ToInt32( TextBox2.Text);
                b.CapacidadTripulantes = Convert.ToInt32(TextBox3.Text);
                b.CapacidadBodega = Convert.ToInt32(TextBox4.Text);
                encargado auth = (encargado) Session["auth"];
                Global.b.createBarco(b, auth);

            }
            else {
                barcoRapido b = new barcoRapido();
                b.Nombre = TextBox1.Text;
                b.CapacidadPasajeros = Convert.ToInt32(TextBox2.Text);
                b.CapacidadTripulantes = Convert.ToInt32(TextBox3.Text);
                b.VelocidadMax = Convert.ToInt32(TextBox4.Text);
                encargado auth = (encargado)Session["auth"];
                Global.b.createBarco(b, auth);
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedItem.Text == "Barco lento")
            {
                Label1.Text = "Capacidad bodega";
            }
            else {
                Label1.Text = "Velocidad maxima";
            }
        }

        
    }
}