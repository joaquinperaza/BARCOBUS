<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="altaMantenimiento.aspx.cs" Inherits="barcobus.altaMantenimiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Alta de reparacion</h2>
    <br />
    Mantenimiento<br />
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    Descripcion<br />
    <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
    <br />
    <br />
    Barco<br />
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <br />
    <asp:Label ID="label" runat="server" style="color: #FF0000; font-weight: 700"></asp:Label>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Cargar" onclick="Button1_Click" />
<br />
</asp:Content>
