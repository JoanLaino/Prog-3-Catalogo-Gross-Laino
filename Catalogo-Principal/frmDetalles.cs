using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Catalogo_Principal
{
    public partial class frmDetalles : Form
    {
        private List<Articulo> listaArticulo;
        public frmDetalles()
        {
            InitializeComponent();
        }

        public void cargarDetalle(string Codigo)
        {
            ArticuloDB articuloDB = new ArticuloDB();
            
            try
            {
                listaArticulo = articuloDB.ListarDetalles(Codigo);
                dvgDetalles.DataSource = listaArticulo;

                RecargarImg(listaArticulo[0].Imagen);
            }
            catch (Exception es)
            {

                MessageBox.Show(es.ToString());
            }
        }

        private void RecargarImg(string img)
        {
            pbxDetalles.Load(img);
        }

    }
}
