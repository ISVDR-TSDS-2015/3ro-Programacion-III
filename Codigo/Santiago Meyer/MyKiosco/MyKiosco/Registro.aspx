<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Registro.aspx.vb" Inherits="MyKiosco.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td colspan="2">
                <h3>Registro de Kiosco</h3>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtNombre" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtUsuario" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtPassword" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtPassword2" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:Label ID="lblCPassword" runat="server" Text="Confirmar Password:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="txtPassword" ControlToValidate="txtPassword2" 
                    ErrorMessage="Las contraseñas no coinciden"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtEMail" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:Label ID="lblEmail" runat="server" Text="E-Mail:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEMail" runat="server" TextMode="Email" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="right">
                <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" />
            </td>
        </tr>
    </table>

</asp:Content>
