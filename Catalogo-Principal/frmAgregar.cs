using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Catalogo_Principal
{
    public partial class frmAgregar : Form
    {
        private Articulo articulo = null;
        public frmAgregar()
        {
            InitializeComponent();
        }

        public frmAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void btnCancelarAgregado_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            MarcaDB marcaDB = new MarcaDB();
            CategoriaDB categoriaDB = new CategoriaDB();

            try
            {
                cboMarcaArticulo.DataSource = marcaDB.Listar();
                cboMarcaArticulo.ValueMember = "Id";
                cboMarcaArticulo.DisplayMember = "Nombre";

                cboCategoriaArticulo.DataSource = categoriaDB.Listar();
                cboCategoriaArticulo.ValueMember = "Id";
                cboCategoriaArticulo.DisplayMember = "Nombre";


                if(articulo != null)
                {
                    txtCodigoArticulo.Text = articulo.Codigo;
                    txtNombreArticulo.Text = articulo.Nombre;
                    txtDescripcionArticulo.Text = articulo.Descripcion;
                    cboCategoriaArticulo.SelectedValue = articulo.Categoria.Id;
                    cboMarcaArticulo.SelectedValue = articulo.Marca.Id;
                    txtImagenArticulo.Text = articulo.Imagen;
                    RecargarImg(txtImagenArticulo.Text);
                    numPrecio.Value = articulo.Precio;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RecargarImg(string img)
        {
            pbxAgregarArticulo.Load(img);
        }

        private void txtImagenArticulo_TextChanged(object sender, EventArgs e)
        {
            RecargarImg(txtImagenArticulo.Text);
        }

        private void btnAgregarSecundario_Click(object sender, EventArgs e)
        {            
            ArticuloDB articuloDB = new ArticuloDB();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigoArticulo.Text;
                articulo.Nombre = txtNombreArticulo.Text;
                articulo.Descripcion = txtDescripcionArticulo.Text;
                articulo.Marca = (Marca)cboMarcaArticulo.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoriaArticulo.SelectedItem;
                articulo.Imagen = txtImagenArticulo.Text;
                articulo.Precio = (decimal)numPrecio.Value;

                if (articulo.Id == 0)
                {
                    articuloDB.agregarArticulo(articulo);
                    MessageBox.Show("Agregado sin problema.");
                }
                else
                {
                    articuloDB.modificarArticulo(articulo);
                    MessageBox.Show("Modificado sin problema.");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }

}
