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
    public partial class CardsArticulos : System.Web.UI.Page
    {
        public List<Articulo> lista;

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloDB articuloDB = new ArticuloDB();
            try
            {
                
                lista = articuloDB.Listar();

                Session.Add("listadoArticulos", lista);
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

        protected void buscarArticulo(object sender, EventArgs e)
        {
            List<Articulo> filtro;
            if (txtFiltro.Text != "")
            {
                filtro = lista.FindAll(Art => Art.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || Art.Marca.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || Art.Categoria.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()));
                lista = null;
                lista = filtro;
            }
        }
    }
}