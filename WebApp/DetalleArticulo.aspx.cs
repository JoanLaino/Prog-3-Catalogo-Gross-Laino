using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebApp
{
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        Articulo item;
        public static List<Articulo> listadoCarrito = new List<Articulo>();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            List<Articulo> listado = (List<Articulo>)Session["listadoArticulos"];
            Articulo seleccionado = listado.Find(x => x.Id == id);

            imgSeleccionado.ImageUrl = seleccionado.Imagen;
            lblCodigo.Text = seleccionado.Codigo;
            lblNombre.Text = seleccionado.Nombre;
            lblDescripcion.Text = seleccionado.Descripcion;
            lblMarca.Text = seleccionado.Marca.Nombre;
            lblCategoria.Text = seleccionado.Categoria.Nombre;
            lblPrecio.Text = Convert.ToString(seleccionado.Precio);

            item = seleccionado;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                listadoCarrito.Add(item);
                Session.Add("listadoCarrito", listadoCarrito);
                Response.Redirect("Carrito.aspx");
            }
            catch (Exception ex)
            {
                Response.Redirect("AgregadoCorrectamente.aspx");
            }
        }
    }
}