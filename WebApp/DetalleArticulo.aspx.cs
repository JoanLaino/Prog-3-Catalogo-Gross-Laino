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
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            List<Articulo> listado = (List<Articulo>)Session["listadoArticulos"];
            Articulo seleccionado = listado.Find(x => x.Id == id);

            lblSeleccionado.Text = seleccionado.Nombre;
            lblUrlImagen.Text = seleccionado.Imagen;
        }
    }
}