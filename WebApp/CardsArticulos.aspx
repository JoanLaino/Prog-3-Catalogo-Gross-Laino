<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CardsArticulos.aspx.cs" Inherits="WebApp.CardsArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


   <%-- <table>
        <tr>
            <td>Nombre</td>
        </tr>
        <% foreach (Dominio.Articulo item in lista)
            {%>

        <tr>
            <td>
               <% = item.Nombre %> 
            </td>
        </tr>

         <%   } %>
    </table>--%>

    <div class="container">
        <div class="row">

            <% foreach (Dominio.Articulo item in lista)
                {%>
            <div class="col">
                <div class="card" style="width: 18rem;">
                    <img src="<% = item.Imagen %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><% = item.Nombre %></h5>
                        <p class="card-text"><% = item.Descripcion %></p>
                        <a href="DetalleArticulo.aspx?id=<% = item.Id %>" class="btn btn-primary">Detalles</a>
                    </div>
                </div>
            </div>
            <%   } %>
        </div>
    </div>


</asp:Content>
