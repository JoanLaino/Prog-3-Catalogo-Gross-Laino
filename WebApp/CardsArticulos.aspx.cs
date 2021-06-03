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
    }
}