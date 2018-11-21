using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace barcobus
{
    public partial class log : System.Web.UI.Page
    {
        DateTime desde;
        DateTime hasta;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void render(){
            GridView1.DataSource = Global.b.logDataTable(desde,hasta);
            GridView1.DataBind();}

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "") { desde = new DateTime(2000, 1, 1); }
            else
            { desde = Convert.ToDateTime(TextBox1.Text); }
            if (TextBox2.Text == "") { desde = DateTime.UtcNow; }
            else
            { hasta = Convert.ToDateTime(TextBox2.Text); }
            render();
        }
    }
}