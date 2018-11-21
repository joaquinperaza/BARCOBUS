<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="asignar.aspx.cs" Inherits="barcobus.asignar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registro de actividades sobre barco</h2>
<br />
Asignar&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server" >
</asp:DropDownList>
&nbsp;al barco
<asp:DropDownList ID="DropDownList2" runat="server">
</asp:DropDownList>
&nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
    Text="Asignar" />
<br />
<br />
<asp:Label ID="label" runat="server" style="color: #FF0000; font-weight: 700"></asp:Label>
<br/>
</asp:Content>
