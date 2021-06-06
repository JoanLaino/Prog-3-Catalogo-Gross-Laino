<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="WebApp.DetalleArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Articulo Seleccionado</h1>
    <center>
    <div class="principal-detalle">
    
        <div class="img-detalle">
                <asp:Image ID="imgSeleccionado" runat="server" class="img-detalle"/>
        </div>
    
       
        <div class="div-detalle">
            <span class="txt-detalle">Código: </span>
            <asp:Label Text="text" ID="lblCodigo" runat="server" CssClass="lbl-detalle" />
            <br />
            <span class="txt-detalle">Nombre: </span>
            <asp:Label Text="Seleccionado" ID="lblNombre" runat="server" CssClass="lbl-detalle" />
            <br />
            <span class="txt-detalle">Descripcion: </span>
            <asp:Label ID="lblDescripcion" runat="server" Text="Label" CssClass="lbl-detalle" />
            <br />
            <span class="txt-detalle">Marca: </span>
            <asp:Label Text="text" ID="lblMarca" runat="server" CssClass="lbl-detalle" />
            <br />
            <span class="txt-detalle">Categoría: </span>
            <asp:Label Text="text" ID="lblCategoria" runat="server" CssClass="lbl-detalle" />
            <br />
            <span class="txt-detalle">$</span>
            <asp:Label Text="text" ID="lblPrecio" runat="server" CssClass="lbl-detalle" />
        </div>
        <center>
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar al Carrito" OnClick="btnAgregar_Click" CssClass="btn-carrito" />
        </center>

    </div>
   </center>
</asp:Content>
