<%@ Page Title="Página principal" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Default.aspx.vb" Inherits="MyKiosco._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: #CC66FF;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        MyKiosco.com
    </h2>
    <p>
        <span class="style1">Sistema Web destinado a pequeños comercios, para puedan comercializar sus 
        productos.</span>
    </p>
    <p>
        <asp:Button ID="btnRegistro" runat="server" Text="Registrar mi Kiosco" />
    </p>
</asp:Content>
