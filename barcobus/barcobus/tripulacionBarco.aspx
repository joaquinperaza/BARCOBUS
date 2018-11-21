<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="tripulacionBarco.aspx.cs" Inherits="barcobus.tripulacionBarco" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <h2>Tripulacion del barco</h2>
<br/>
    Barco<br/><asp:DropDownList ID="DropDownList1" runat="server" 
        AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList><br/><br/>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
