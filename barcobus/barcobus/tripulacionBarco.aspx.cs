using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barcobus
{
    public partial class tripulacionBarco : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.DataSource = Global.b.barcoList();
            if (!IsPostBack)
            {
                DropDownList1.DataBind();
                DropDownList1.SelectedIndex = 0;
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {barco actual = Global.b.barcoList().Find(b2 => b2.Nombre == DropDownList1.SelectedItem.Text);
        GridView1.DataSource = Global.b.tripulacion(actual);
        GridView1.DataBind();
        }
    }
}