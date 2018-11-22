using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barcobus
{
    public partial class resumen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Capitanes: " + Convert.ToString(Global.b.tripulantes().capitanes);
            Label2.Text = "Comisarios: " + Convert.ToString(Global.b.tripulantes().comisarios);
            Label3.Text = "Jefed de maquina: " + Convert.ToString(Global.b.tripulantes().jefesDeMaquina);
            Label4.Text = "Oficiales de cubierta: " + Convert.ToString(Global.b.tripulantes().oficialesCubierta);
            Label5.Text = "Pilotos: " + Convert.ToString(Global.b.tripulantes().pilotos);
            Label6.Text = "Servicios: " + Convert.ToString(Global.b.tripulantes().servicios);
            
        }
    }
}