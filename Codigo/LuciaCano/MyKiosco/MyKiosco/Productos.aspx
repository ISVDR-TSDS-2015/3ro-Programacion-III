<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Productos.aspx.vb" Inherits="MyKiosco.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 347px;
        }
        .style3
        {
        }
        .style4
        {
            width: 366px;
        }
        .style5
        {
            color: #CC66FF;
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <span class="style5">PRODUCTOS</span><br />
    <br />
    <table style="width: 475px">
        <tr>
            <td colspan="2">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="Id" EmptyDataText="No hay Productos registrados" Width="470px">
        <Columns>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="Stock" HeaderText="Stock" />
            <asp:BoundField DataField="Unidad" HeaderText="Unidad" />
            <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="style1" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                <asp:Label ID="Label2" runat="server" Text="Nuevo Producto"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                <asp:Label ID="Label3" runat="server" Text="Stock"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="TxtStock" runat="server"></asp:TextBox>
    <asp:DropDownList ID="CmbUnidad" runat="server">
        <asp:ListItem>Kg.</asp:ListItem>
        <asp:ListItem>Un.</asp:ListItem>
        <asp:ListItem>gr.</asp:ListItem>
        <asp:ListItem>Mts.</asp:ListItem>
        <asp:ListItem>cm.</asp:ListItem>
        <asp:ListItem>Lts.</asp:ListItem>
    </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style2">
    <asp:Button ID="CmdCancelar" runat="server" Text="Cancelar" />
    <asp:Button ID="CmdEliminar" runat="server" Text="Eliminar" />
            </td>
        </tr>
        <tr>
            <td class="style3" colspan="2" align="right">
    <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="ERROR"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <br />
</asp:Content>
