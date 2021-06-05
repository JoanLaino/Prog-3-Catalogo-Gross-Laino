<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebApp.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td>
                 Nombre
            </td>
            <td>
                Precio
            </td>
            
        </tr>
        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>

                <tr>
                    <td>
                        <%#Eval("Nombre")%>
                    </td>
                    <td>
                        $ <%#Eval("Precio")%>
                    </td>
                    <td>
                        <asp:Button ID="btnEliminar" CssClass="btn btn-primary" Text="Eliminar" CommandArgument='<%#Eval("Id")%>' runat="server" OnClick="quitarArticulo" />
                    </td>
                </tr>

            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>
