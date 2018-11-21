using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barcobus
{
    public partial class altaMantenimiento : System.Web.UI.Page
    {
        List<barco> bl;
        protected void Page_Load(object sender, EventArgs e)
        {
            bl = Global.b.barcoList();
            DropDownList1.DataSource = bl;
            DropDownList2.DataSource = Global.b.listaMantenimiento();
            if (!IsPostBack)
            {
                DropDownList1.DataBind();
                DropDownList2.DataBind();
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
            }
            else try
                {
                    registroMantenimiento rr = new registroMantenimiento();
                    rr.Mantenimiento=Global.b.listaMantenimiento().Find(m=>m.Descripcion==DropDownList2.SelectedItem.Text);
                    barco actual = Global.b.barcoList().Find(b2 => b2.Nombre == DropDownList1.SelectedItem.Text);
                    if (actual.GetType() == typeof(barcoLento)){rr.Costo=rr.Mantenimiento.PrecioBase+((barcoLento)actual).Adicional;}
                    if (actual.GetType() == typeof(barcoRapido)){rr.Costo=Convert.ToInt32(rr.Mantenimiento.PrecioBase*1.3)+100;}
                    
                    rr.Descripcion = TextBox2.Text;
                    rr.Encargado = auth;
                    Global.b.registrarMantenimeinto(rr, actual, auth);
                    label.Text = "Registro creado!";
                    
                }
                catch { }
        }

       
    }
}