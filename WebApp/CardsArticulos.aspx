﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CardsArticulos.aspx.cs" Inherits="WebApp.CardsArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


   <%-- <center>
    <div class="container">
        <div class="row">

            <% foreach (Dominio.Articulo item in lista)
                {%>
            <div class="col">
                <div class="card h-100" style="width: 18rem;">
                    <center>
                        <img src="<% = item.Imagen %>" class="card-img-top img-cards" alt="...">
                    </center>
                    <div class="card-body">
                        <h5 class="card-title"><% = item.Nombre %></h5>--%>
                        <%--<p class="card-text"><% = item.Descripcion %></p>--%>
                        <%--<h6>$ <% = item.Precio %></h6>
                        <br />
                        <a href="DetalleArticulo.aspx?id=<% = item.Id %>" class="btn btn-primary btn-cards-carrito-2">Detalles</a>
                        <a href="#" class="btn btn-primary btn-cards-carrito">+ Carrito</a>

                    </div>
                </div>
            </div>
            <%   } %>
        </div>
    </div>
        </center>--%>

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
                        <a href="#" class="btn btn-primary btn-cards-carrito">+ Carrito</a>
                    </div>
                </div>
            </div>
        </div>    
         <%   } %>
    </div>
    </div>
    </center>

</asp:Content>
