<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="barcoLog.aspx.cs" Inherits="barcobus.barcoLog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registro de actividades sobre barco</h2>
<br/>
Barco: 
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
<br />
<br />
Mes: 
    <asp:Calendar ID="Calendar1" runat="server" 
    onselectionchanged="Calendar1_SelectionChanged"></asp:Calendar>
<br />
<asp:GridView ID="GridView1" runat="server">
</asp:GridView>
</asp:Content>


