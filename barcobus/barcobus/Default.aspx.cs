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
        
        protected void Page_Load(object sender, EventArgs e)
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
            
         }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            encargado admin = new encargado();
            admin.Nombre = TextBox1.Text;
            admin.Password = Global.b.CalculateMD5Hash(TextBox2.Text);
            admin.Ci = Convert.ToInt32( TextBox3.Text);
            admin.Permisos = 3;
            admin.PersonasACargo = 0;
            Global.b.initEncargado(admin);
            Session["auth"] = admin;
            Panel1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text != "" && TextBox5.Text != "")
            {
            encargado Auth = Global.b.login(Convert.ToInt32(TextBox4.Text), Global.b.CalculateMD5Hash( TextBox5.Text));
            if (Auth == null) { Label1.Text = "Credenciales invalidas"; }
            else { Session["auth"] = Auth;
            Panel2.Visible = false;
            }} else {
                Label1.Text = "Ingrese sus datos de usuario";
            }
            
        }

      
    }
}
