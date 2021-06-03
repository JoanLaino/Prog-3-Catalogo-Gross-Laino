<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaArticulos.aspx.cs" Inherits="WebApp.ListaArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Articulos</h1>

    <asp:GridView ID="dgvArticulos" runat="server"></asp:GridView>

    <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
</asp:Content>
