using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barcobus
{
    public partial class _Default : System.Web.UI.Page
    {
        Panel1.Visible = false;
            Panel2.Visible = false;
            if (Global.b.boot())
            {
                Panel1.Visible = true;
            }
            else if (Session["auth"]==null) {

                Panel2.Visible = true;
            }
        protected void Page_Load(object sender, EventArgs e)
        {  
            
            
         }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            encargado admin = new encargado();
            admin.Nombre = TextBox1.Text;
            admin.Password = Global.b.CalculateMD5Hash(TextBox2.Text);
            admin.Ci = Convert.ToInt32( TextBox3.Text);
            admin.Permisos = 5;
            admin.PersonasACargo = 0;
            Global.b.initEncargado(admin);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            encargado Auth = Global.b.login(Convert.ToInt32(TextBox4.Text), Global.b.CalculateMD5Hash( TextBox5.Text));
            if (Auth == null) { Label1.Text = "Credenciales invalidas"; }
            else { Session["auth"] = Auth; }
        }

      
    }
}
