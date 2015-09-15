<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.vb" Inherits="MyKiosco.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
    <asp:TextBox ID="TxtUsuario" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
    <asp:TextBox ID="TxtContrasenia" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Button ID="CmdAceptar" runat="server" Text="Aceptar" />
    <br />
    <asp:Label ID="LblResultado" runat="server" Text="LblResultado"></asp:Label>
</asp:Content>
