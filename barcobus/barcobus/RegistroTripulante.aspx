<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroTripulante.aspx.cs" Inherits="barcobus.RegistroTripulante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>Crear nuevo Tripulante.</h2>
     <br />
    Nombre<br><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/><br/>
    Cedula<br/><asp:TextBox ID="TextBox2" runat="server" 
        TextMode="Number"></asp:TextBox><br/><br/>
    Rol<br/>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="1">Capitan</asp:ListItem>
        <asp:ListItem Value="2">Oficial de cubierta</asp:ListItem>
        <asp:ListItem Value="3">Piloto</asp:ListItem>
        <asp:ListItem Value="4">Comisario de a bordo</asp:ListItem>
        <asp:ListItem Value="5">Jefe de Maquinas</asp:ListItem>
        <asp:ListItem Value="6">Servicios</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Crear tripulante" 
        onclick="Button1_Click" />
    <br/>
   
</asp:Content>
