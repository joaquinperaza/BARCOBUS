<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="log.aspx.cs" Inherits="barcobus.log" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registro de actividad</h2>
    <br />
    Desde:
    <asp:TextBox ID="TextBox1" runat="server" 
        TextMode="Date"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <br />
    Hasta:&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"  
         TextMode="Date"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Filtrar" />
    <br />
     <br />
    <asp:GridView ID="GridView1" runat="server">
</asp:GridView>

</asp:Content>
