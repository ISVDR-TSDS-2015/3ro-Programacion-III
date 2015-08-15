<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.vb" Inherits="MyKiosco.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
<asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
<br />
<asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
<asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password"></asp:TextBox>
<br />
<asp:Button ID="cmdAceptar" runat="server" Text="Aceptar" />
<br />
<asp:Label ID="lblResultado" runat="server"></asp:Label>
</asp:Content>
