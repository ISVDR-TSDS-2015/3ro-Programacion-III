<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Menu.aspx.vb" Inherits="MyKiosco.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Productos" runat="server" Text="Productos" />
    <asp:Button ID="CmdCompras" runat="server" Text="Compras" />
    <asp:Button ID="Ventas" runat="server" Text="Ventas" />
</asp:Content>
