using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barcobus
{
    public partial class revocar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.DataSource = Global.b.encargadoList();
            if (!IsPostBack)
            {
                DropDownList1.DataBind();
                DropDownList1.SelectedIndex = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {encargado auth = (encargado)Session["auth"];
            if (auth==null)
        {
            label.Text = "Debe ingresar al sistema.";
        }
        else if (auth.Permisos < 3)
            {
                label.Text = "No cuenta con los permisos necesarios para completar la operacion.";
                encargado arevocar = Global.b.encargadoList().Find(e2 => e2.Nombre == DropDownList1.SelectedItem.Text);
                Global.b.editarPermiso(auth, arevocar, Convert.ToInt32(DropDownList2.SelectedValue));
            }
            else try
            {
            encargado arevocar = Global.b.encargadoList().Find(e2 => e2.Nombre == DropDownList1.SelectedItem.Text);
            Global.b.editarPermiso(auth, arevocar, Convert.ToInt32(DropDownList2.SelectedValue));
            label.Text = "Permisos modificados!";
            }catch{}
        }
    }
}