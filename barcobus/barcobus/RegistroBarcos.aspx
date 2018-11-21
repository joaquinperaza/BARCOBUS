<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroBarcos.aspx.cs" Inherits="barcobus.RegistroBarcos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Crear nuevo barco</h2>
<br/>
  <asp:RadioButtonList id="RadioButtonList1" runat="server" 
        onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="true">
        <asp:ListItem Selected="True">Barco lento</asp:ListItem>
        <asp:ListItem>Barco rapido</asp:ListItem>
     </asp:RadioButtonList>
     <br />
    Nombre<br><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/><br/>
    Capacidad pasajeros<br/><asp:TextBox ID="TextBox2" runat="server" 
        TextMode="Number"></asp:TextBox><br/><br/>
    Capacidad tripulantes<br/><asp:TextBox ID="TextBox3" runat="server" 
        TextMode="Number"></asp:TextBox>
    <br /><br/>
    <asp:Label ID="Label1" runat="server" Text="Label">Capacidad bodega</asp:Label><br/><asp:TextBox ID="TextBox4" runat="server" 
        TextMode="Number"></asp:TextBox>
    <br />
<br />
Base<br />
<asp:TextBox ID="TextBox5" runat="server" TextMode="Number"></asp:TextBox>
    <br />
    <asp:Label ID="label" runat="server" Text="" 
        style="color: #FF0000; font-weight: 700"></asp:Label>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Crear barco" 
        onclick="Button1_Click" />
    <br/>
   
</asp:Content>
