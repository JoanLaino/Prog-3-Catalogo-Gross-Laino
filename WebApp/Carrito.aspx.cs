using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace WebApp
{
    public partial class Carrito : System.Web.UI.Page
    {
        public static List<Articulo> carrito;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                carrito = (List<Articulo>)Session["listadoCarrito"];
                if (carrito != null)
                {
                    if (!IsPostBack)
                    {

                        if (Request.QueryString["id"] != null)
                        {
                            List<Articulo> listadoPrincipal = (List<Articulo>)Session["listadoArticulos"];
                            carrito.Add(listadoPrincipal.Find(x => x.Id.ToString() == Request.QueryString["id"]));
                        }

                        repetidor.DataSource = carrito;
                        repetidor.DataBind();

                    }

                    decimal totalCarrito = 0;
                    totalCarrito = carrito.Sum(x => x.Precio);
                    lblTotalCarrito.Text = Convert.ToString(totalCarrito);
                    decimal sumaCarrito = 0;
                    sumaCarrito = carrito.Count();
                    lblSumaCarrito.Text = Convert.ToString(sumaCarrito);

                    Session.Add("listadoCarrito", carrito);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void quitarArticulo(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
            List<Articulo> carrito = (List<Articulo>)Session["listadoCarrito"];
            Articulo elim = carrito.Find(x => x.Id.ToString() == argument);
            carrito.Remove(elim);

            decimal totalCarrito = carrito.Sum(x => x.Precio);
            lblTotalCarrito.Text = Convert.ToString(totalCarrito);
            decimal sumaCarrito = carrito.Count();
            lblSumaCarrito.Text = Convert.ToString(sumaCarrito);

            Session.Add("listadoCarrito", carrito);
            repetidor.DataSource = null;
            repetidor.DataSource = carrito;
            repetidor.DataBind();
        }
    }
}