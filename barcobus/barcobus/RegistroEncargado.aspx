<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroEncargado.aspx.cs" Inherits="barcobus.RegistroEncargado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Crear nuevo ENCARGADO</h2>
     <br />
    Nombre<br><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/><br/>
    Cedula<br/><asp:TextBox ID="TextBox2" runat="server" 
        TextMode="Number"></asp:TextBox>
    <br />
    <br />
    Personas a cargo<br/>
    <asp:TextBox ID="TextBox3" runat="server" 
        TextMode="Number"></asp:TextBox><br/>
    <br />
    Clave<br/>
    <asp:TextBox ID="TextBox4" runat="server" 
        TextMode="Password"></asp:TextBox>
    <br />
    <br/>
    Privilegio<br/>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="1">Solo edicion</asp:ListItem>
        <asp:ListItem Value="2">Edicion y creacion</asp:ListItem>
        <asp:ListItem Value="3">Administrador</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="label" runat="server" 
        style="color: #FF0000; font-weight: 700"></asp:Label>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Crear tripulante" 
        onclick="Button1_Click" />
    <br/>
   
</asp:Content>
