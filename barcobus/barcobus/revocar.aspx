<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="revocar.aspx.cs" Inherits="barcobus.revocar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Revocar permisos</h2>

    <br />
    Encargado<br />
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    Nuevo permiso<br />
  <asp:DropDownList ID="DropDownList2" runat="server">
        <asp:ListItem Value="1">Solo edicion</asp:ListItem>
        <asp:ListItem Value="2">Edicion y creacion</asp:ListItem>
        <asp:ListItem Value="3">Administrador</asp:ListItem>
    </asp:DropDownList>

    <br />
    <br />
    <asp:Label ID="label" runat="server" 
        style="color: #FF0000; font-weight: 700"></asp:Label>
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Revocar permiso" />

<br/>
</asp:Content>
