<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregadoCorrectamente.aspx.cs" Inherits="WebApp.AgregadoCorrectamente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <center>
    <div class="cont-correcto">
        
        <h2 class="txt-correcto-1">¡El producto se ha agregado con éxito!</h2>
        <br />
        <h4 class="txt-correcto-2">¿Qué desea hacer?</h4>

    <asp:Button ID="btnContinuarInicio" runat="server" Text="Ir al Inicio" CssClass="btn-cont-inicio" OnClick="btnContinuarInicio_Click"></asp:Button>
    <asp:Button ID="btnContinuarCarrito" runat="server" Text="Ir al Carrito" CssClass="btn-cont-carrito" OnClick="btnContinuarCarrito_Click"></asp:Button>
    </div>
    </center>

</asp:Content>
