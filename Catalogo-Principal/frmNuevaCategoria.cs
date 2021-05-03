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
    public partial class frmNuevaCategoria : Form
    {
        public frmNuevaCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelarNuevaCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmarNuevaCategoria_Click(object sender, EventArgs e)
        {
            ArticuloDB articuloDB = new ArticuloDB();

            try
            {
                if (txtNombreNuevaCategoria.Text != "")
                {
                    Categoria categoria = new Categoria(txtNombreNuevaCategoria.Text);
                    articuloDB.agregarCategoria(categoria);
                    if (MessageBox.Show("La categoría se ha agregado correctamente.\n\r¿Desea agregar otra categoría?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        Close();
                    }
                    txtNombreNuevaCategoria.ResetText();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
