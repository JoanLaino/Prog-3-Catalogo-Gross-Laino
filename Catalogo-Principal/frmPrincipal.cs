﻿using System;
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

                //Ocultar
                //dvgArticulos.Columns["Codigo"].Visible = false;
                dvgArticulos.Columns["Descripcion"].Visible = false;
                dvgArticulos.Columns["Categoria"].Visible = false;
                dvgArticulos.Columns["Imagen"].Visible = false;


                RecargarImg(listaArticulo[0].Imagen);
            }
            catch (Exception es)
            {

                MessageBox.Show(es.ToString());
            }
        }
      
        private void RecargarImg(string img)
        {
            pbxArticulo.Load(img);
        }

        private void dgvArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            Articulo seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
            RecargarImg(seleccionado.Imagen);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JoanLaino/Prog-TP2-Gross-Laino.git");
        }
    }
}
