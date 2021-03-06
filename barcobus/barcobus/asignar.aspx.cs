﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barcobus
{
    public partial class asignar : System.Web.UI.Page
    {
        List<barco> bl;
        List<tripulante> tl;
        protected void Page_Load(object sender, EventArgs e)
        {
            bl = Global.b.barcoList();
            DropDownList2.DataSource = bl;
            tl = Global.b.tripulanteList();
            DropDownList1.DataSource = tl;
            if (!IsPostBack)
            {
                DropDownList2.DataBind();
                DropDownList1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {encargado auth = (encargado)Session["auth"];
            if (auth==null)
        {
            label.Text = "Debe ingresar al sistema.";
        }
        else if (auth.Permisos < 1)
            {
                label.Text = "No cuenta con los permisos necesarios para completar la operacion.";
                int result = Global.b.asignarTripulante(DropDownList2.SelectedItem.Text, auth, DropDownList1.SelectedItem.Text);
            }
            else try
                {
                    int result=Global.b.asignarTripulante(DropDownList2.SelectedItem.Text, auth, DropDownList1.SelectedItem.Text);
                    label.Text = "Asignado " + DropDownList1.SelectedItem.Text +" al barco "+ DropDownList2.SelectedItem.Text + "!";
                    if (result == 2) { label.Text = "Tripulacion llena."; }
                    if (result == 3) { label.Text = "Ya es tripulante."; }
                    if (result == 4) {label.Text = "Demasiados capitanes."; }
                }
                catch { }
        }
    }
}