<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="crearMantenimiento.aspx.cs" Inherits="barcobus.crearMantenimiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>Crear nuevo mantenimiento</h2>
     <br />
    Codigo<br><asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
    <br />
    <br />
    Descripcion<br><asp:TextBox ID="TextBox2" runat="server" TextMode="SingleLine"></asp:TextBox>
    <br />
    <br />
    Precio base<br><asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="label" runat="server" Text="" 
        style="font-weight: 700; color: #FF0000"></asp:Label>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Crear mantenimiento" 
        onclick="Button1_Click" />
    <br/>
</asp:Content>
