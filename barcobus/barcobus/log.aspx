<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="log.aspx.cs" Inherits="barcobus.log" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>Registro de actividad</h2>
     <br />
    <asp:ListView ID="ListView1" runat="server">
    </asp:ListView>
</asp:Content>
