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
    public partial class frmPrincipal : Form
    {
        private List<Articulo> listaArticulo;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
            cargarListado();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargarListado();      
        }

        private void cargarListado()
        {          

            ArticuloDB articuloDB = new ArticuloDB();

            try
            {
                listaArticulo = articuloDB.Listar();
                dvgArticulos.DataSource = listaArticulo;

                columnasOcultas();


                RecargarImg(listaArticulo[0].Imagen);
            }
            catch (Exception es)
            {

                MessageBox.Show(es.ToString());
            }
        }

        private void columnasOcultas()
        {
            //Ocultar
            dvgArticulos.Columns["Id"].Visible = false;
            dvgArticulos.Columns["Codigo"].Visible = false;
            dvgArticulos.Columns["Descripcion"].Visible = false;
            dvgArticulos.Columns["Categoria"].Visible = false;
            dvgArticulos.Columns["Imagen"].Visible = false;
        }
      
        private void RecargarImg(string img)
        {
            pbxArticulo.Load(img);
        }

        private void dvgArticulos_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
            RecargarImg(seleccionado.Imagen);
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
            
            frmDetalles detalle = new frmDetalles();

            try
            {
                detalle.cargarDetalle(seleccionado.Codigo);
                
            }
            catch (Exception)
            {

                throw;
            }
            
            detalle.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
            ArticuloDB articuloDB = new ArticuloDB();

            try
            {
                if(MessageBox.Show("Para confirmar la eliminación del artículo, presione Sí", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    articuloDB.EliminarArticulo(seleccionado.Codigo);
                    MessageBox.Show("El artículo " + seleccionado.Nombre + " se ha eliminado correctamente");
                    cargarListado();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
            frmAgregar modificar = new frmAgregar(seleccionado);
            modificar.ShowDialog();
            cargarListado();
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            buscar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            List<Articulo> filtro;
            if (txtFiltro.Text != "")
            {
                filtro = listaArticulo.FindAll(Art => Art.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || Art.Marca.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || Art.Categoria.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()));
                dvgArticulos.DataSource = null;
                dvgArticulos.DataSource = filtro;
            }
            else
            {
                dvgArticulos.DataSource = null;
                dvgArticulos.DataSource = listaArticulo;
            }

            columnasOcultas();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmNuevaMarca agregar = new frmNuevaMarca();
            agregar.ShowDialog();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmNuevaCategoria agregar = new frmNuevaCategoria();
            agregar.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JoanLaino/TP-WinForm-Gross-Laino");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JoanLaino/TP-WinForm-Gross-Laino");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JoanLaino/TP-WinForm-Gross-Laino");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JoanLaino/TP-WinForm-Gross-Laino");
        }

    }
}
