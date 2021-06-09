using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class SiteMaster : MasterPage
    {
        public int sumaCarrito;
        protected void Page_Load(object sender, EventArgs e)
        {
            sumaCarrito = Convert.ToInt32(Session["cantidadEnCarrito"]);
        }
    }
}