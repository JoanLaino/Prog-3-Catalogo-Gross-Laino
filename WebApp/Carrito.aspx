<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebApp.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td>
                <span class="txt-carrito"></span>
            </td>
            <td>
                <span class="txt-carrito">Nombre</span>
            </td>
            <td>
                <span class="txt-carrito">Precio</span>
            </td>
            <hr />
        </tr>
        
        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                
                <tr>
                    <td class="img-carrito">
                        <img src="<%#Eval("Imagen")%>" width="40px"/>
                    </td>
                    <td class="nom-carrito">
                        <%#Eval("Nombre")%>
                    </td>
                    <td class="imp-carrito">
                        $ <%#Eval("Precio")%>
                    </td>
                    <td>
                        <asp:Button ID="btnEliminar" CssClass="btn btn-primary btn-carrito-eliminar" Text="Eliminar" CommandArgument='<%#Eval("Id")%>' runat="server" OnClick="quitarArticulo" />
                    </td>
                </tr>

            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>
