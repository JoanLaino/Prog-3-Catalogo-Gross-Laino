<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CardsArticulos.aspx.cs" Inherits="WebApp.CardsArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <center>
        <asp:Button OnClick="buscarArticulo" ID="btnBuscar" runat="server" Text="Buscar" />
        <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
    </center>

    <center>
    <div class="container">
    <div class="row row-cols-1 row-cols-md-3">
        <% foreach (Dominio.Articulo item in lista)
                {%>
        <div class="col mb-4">
            <div class="card stl-card h-100">
                <center>
                    <img src="<% = item.Imagen %>" class="card-img-top img-cards" alt="...">
                </center>
                <div class="card-body">
                    <h5 class="card-title"><% = item.Nombre %></h5>
                    <h6>$ <% = item.Precio %></h6>
                    <br />
                    <div class="btn-detalle-general">
                        <a href="DetalleArticulo.aspx?id=<% = item.Id %>" class="btn btn-primary btn-cards-carrito-2">Detalles</a>
                        <%--<a href="#" ID="" class="btn btn-primary btn-cards-carrito">+ Carrito</a>--%>
                    </div>
                </div>
            </div>
        </div>    
         <%   } %>
    </div>
    </div>
    </center>

</asp:Content>
