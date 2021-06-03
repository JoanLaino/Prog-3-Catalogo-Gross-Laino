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
    public partial class ListaArticulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloDB articuloDB = new ArticuloDB();
            try
            {
                dgvArticulos.DataSource = articuloDB.Listar();
                dgvArticulos.DataBind();
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormularioArticulos.aspx");
        }
    }
}