<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="barcobus._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p>
        <asp:Label ID="Label2" runat="server" style="font-size: x-large"></asp:Label>
    </p>
    <asp:Panel ID="Panel1" runat="server">
    
        <strong>PANEL</strong> <strong>DE</strong> <strong>INICIALIZACION DE LA APP<br />
        </strong>
        <br />
&nbsp;Nombre del administrador<br />
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Clavemaestra<br />
        <asp:TextBox ID="TextBox2" runat="server" 
            TextMode="Password"></asp:TextBox>
        <br />
        <br />
        CI<br />
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>


        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Crear administrador" />
        <br />


    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
     <strong>LOGIN<br />
        <br />
        CI:<br />
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        CLAVE:<br />
        <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        </strong>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="LOGIN" />
        <strong>
        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
        </strong><br />

    </asp:Panel>






</asp:Content>
