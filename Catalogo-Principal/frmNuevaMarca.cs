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
    public partial class frmNuevaMarca : Form
    {
        public frmNuevaMarca()
        {
            InitializeComponent();
        }

        private void btnCancelarNuevaMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmarNuevaMarca_Click(object sender, EventArgs e)
        {
            ArticuloDB articuloDB = new ArticuloDB();

            try
            {
                if (txtNombreNuevaMarca.Text != "")
                {
                    Marca marca = new Marca(txtNombreNuevaMarca.Text);
                    articuloDB.agregarMarca(marca);
                    if (MessageBox.Show("La marca se ha agregado correctamente.\n\r¿Desea agregar otra marca?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        Close();
                    }
                    txtNombreNuevaMarca.ResetText();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
