using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barcobus
{
    public partial class barcoLog : System.Web.UI.Page
    {
        List<barco> bl;
        protected void Page_Load(object sender, EventArgs e)
        {
            bl = Global.b.barcoList();
            DropDownList1.DataSource = bl;
            if(!IsPostBack){ 
            DropDownList1.DataBind();
            DropDownList1.SelectedIndex = 0;}

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

            GridView1.DataSource = Global.b.barcoLog(DropDownList1.SelectedItem.Text, Calendar1.SelectedDate);
            GridView1.DataBind();
        }

    }
}