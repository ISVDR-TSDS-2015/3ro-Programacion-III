<%@ Page Title="Acerca de nosotros" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="About.aspx.vb" Inherits="MyKiosco.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: #CC66FF;
        }
        .style2
        {
            color: #999999;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2 class="style2">
        Acerca de
        MyKiosco.com</h2>
    <p>
        <span class="style1">Desarrollado por Lucia Cano</p>
    <p>
        Programación III </p>
    <p>
        &nbsp;Tecnicatura Superior en Desarrollo de Software </p>
    <p>
        Instituto Superior Villa del Rosario</p>
    <p>
        Profesor Javier Pintos</span></p>
</asp:Content>
