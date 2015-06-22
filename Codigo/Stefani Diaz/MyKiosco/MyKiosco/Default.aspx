<%@ Page Title="Página principal" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Default.aspx.vb" Inherits="MyKiosco._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        MyKiosco.com
    </h2>
    <p>
        Sistema Web destinado a pequeños comercios, para puedan comercializar sus 
        productos.
    </p>
    <p>
        <asp:Button ID="btnRegistro" runat="server" Text="Registrar mi Kiosco" />
    </p>
</asp:Content>
