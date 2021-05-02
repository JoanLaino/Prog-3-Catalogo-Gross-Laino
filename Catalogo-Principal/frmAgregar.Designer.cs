
namespace Catalogo_Principal
{
    partial class frmAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarSecundario = new System.Windows.Forms.Button();
            this.btnCancelarAgregado = new System.Windows.Forms.Button();
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.lblCategoriaArticulo = new System.Windows.Forms.Label();
            this.lblImgArticulo = new System.Windows.Forms.Label();
            this.lblMarcaArticulo = new System.Windows.Forms.Label();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.txtImagenArticulo = new System.Windows.Forms.TextBox();
            this.cboMarcaArticulo = new System.Windows.Forms.ComboBox();
            this.cboCategoriaArticulo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbxAgregarArticulo = new System.Windows.Forms.PictureBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarSecundario
            // 
            this.btnAgregarSecundario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(244)))), ((int)(((byte)(165)))));
            this.btnAgregarSecundario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarSecundario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarSecundario.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSecundario.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarSecundario.Location = new System.Drawing.Point(240, 371);
            this.btnAgregarSecundario.Name = "btnAgregarSecundario";
            this.btnAgregarSecundario.Size = new System.Drawing.Size(119, 35);
            this.btnAgregarSecundario.TabIndex = 1;
            this.btnAgregarSecundario.Text = "Agregar";
            this.btnAgregarSecundario.UseVisualStyleBackColor = false;
            this.btnAgregarSecundario.Click += new System.EventHandler(this.btnAgregarSecundario_Click);
            // 
            // btnCancelarAgregado
            // 
            this.btnCancelarAgregado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnCancelarAgregado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarAgregado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarAgregado.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAgregado.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarAgregado.Location = new System.Drawing.Point(433, 371);
            this.btnCancelarAgregado.Name = "btnCancelarAgregado";
            this.btnCancelarAgregado.Size = new System.Drawing.Size(119, 35);
            this.btnCancelarAgregado.TabIndex = 3;
            this.btnCancelarAgregado.Text = "Cancelar";
            this.btnCancelarAgregado.UseVisualStyleBackColor = false;
            this.btnCancelarAgregado.Click += new System.EventHandler(this.btnCancelarAgregado_Click);
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Location = new System.Drawing.Point(108, 48);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(43, 13);
            this.lblCodArticulo.TabIndex = 5;
            this.lblCodArticulo.Text = "Código:";
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Location = new System.Drawing.Point(104, 89);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(47, 13);
            this.lblNombreArticulo.TabIndex = 6;
            this.lblNombreArticulo.Text = "Nombre:";
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(85, 132);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionArticulo.TabIndex = 7;
            this.lblDescripcionArticulo.Text = "Descripción:";
            // 
            // lblCategoriaArticulo
            // 
            this.lblCategoriaArticulo.AutoSize = true;
            this.lblCategoriaArticulo.Location = new System.Drawing.Point(94, 217);
            this.lblCategoriaArticulo.Name = "lblCategoriaArticulo";
            this.lblCategoriaArticulo.Size = new System.Drawing.Size(57, 13);
            this.lblCategoriaArticulo.TabIndex = 8;
            this.lblCategoriaArticulo.Text = "Categoría:";
            // 
            // lblImgArticulo
            // 
            this.lblImgArticulo.AutoSize = true;
            this.lblImgArticulo.Location = new System.Drawing.Point(81, 256);
            this.lblImgArticulo.Name = "lblImgArticulo";
            this.lblImgArticulo.Size = new System.Drawing.Size(70, 13);
            this.lblImgArticulo.TabIndex = 9;
            this.lblImgArticulo.Text = "URL Imagen:";
            // 
            // lblMarcaArticulo
            // 
            this.lblMarcaArticulo.AutoSize = true;
            this.lblMarcaArticulo.Location = new System.Drawing.Point(111, 176);
            this.lblMarcaArticulo.Name = "lblMarcaArticulo";
            this.lblMarcaArticulo.Size = new System.Drawing.Size(40, 13);
            this.lblMarcaArticulo.TabIndex = 10;
            this.lblMarcaArticulo.Text = "Marca:";
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.AutoSize = true;
            this.lblPrecioArticulo.Location = new System.Drawing.Point(111, 297);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioArticulo.TabIndex = 11;
            this.lblPrecioArticulo.Text = "Precio:";
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(161, 45);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(274, 20);
            this.txtCodigoArticulo.TabIndex = 12;
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(162, 86);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(274, 20);
            this.txtNombreArticulo.TabIndex = 13;
            // 
            // txtDescripcionArticulo
            // 
            this.txtDescripcionArticulo.Location = new System.Drawing.Point(161, 129);
            this.txtDescripcionArticulo.Name = "txtDescripcionArticulo";
            this.txtDescripcionArticulo.Size = new System.Drawing.Size(274, 20);
            this.txtDescripcionArticulo.TabIndex = 14;
            // 
            // txtImagenArticulo
            // 
            this.txtImagenArticulo.Location = new System.Drawing.Point(161, 256);
            this.txtImagenArticulo.Name = "txtImagenArticulo";
            this.txtImagenArticulo.Size = new System.Drawing.Size(274, 20);
            this.txtImagenArticulo.TabIndex = 16;
            this.txtImagenArticulo.TextChanged += new System.EventHandler(this.txtImagenArticulo_TextChanged);
            // 
            // cboMarcaArticulo
            // 
            this.cboMarcaArticulo.FormattingEnabled = true;
            this.cboMarcaArticulo.Location = new System.Drawing.Point(162, 173);
            this.cboMarcaArticulo.Name = "cboMarcaArticulo";
            this.cboMarcaArticulo.Size = new System.Drawing.Size(273, 21);
            this.cboMarcaArticulo.TabIndex = 17;
            // 
            // cboCategoriaArticulo
            // 
            this.cboCategoriaArticulo.FormattingEnabled = true;
            this.cboCategoriaArticulo.Location = new System.Drawing.Point(162, 217);
            this.cboCategoriaArticulo.Name = "cboCategoriaArticulo";
            this.cboCategoriaArticulo.Size = new System.Drawing.Size(273, 21);
            this.cboCategoriaArticulo.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Gross";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "and";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Laino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(94, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 27);
            this.label8.TabIndex = 22;
            this.label8.Text = "®";
            // 
            // pbxAgregarArticulo
            // 
            this.pbxAgregarArticulo.Location = new System.Drawing.Point(520, 45);
            this.pbxAgregarArticulo.Name = "pbxAgregarArticulo";
            this.pbxAgregarArticulo.Size = new System.Drawing.Size(218, 272);
            this.pbxAgregarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAgregarArticulo.TabIndex = 23;
            this.pbxAgregarArticulo.TabStop = false;
            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Location = new System.Drawing.Point(162, 297);
            this.numPrecio.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(273, 20);
            this.numPrecio.TabIndex = 24;
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(235)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.pbxAgregarArticulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboCategoriaArticulo);
            this.Controls.Add(this.cboMarcaArticulo);
            this.Controls.Add(this.txtImagenArticulo);
            this.Controls.Add(this.txtDescripcionArticulo);
            this.Controls.Add(this.txtNombreArticulo);
            this.Controls.Add(this.txtCodigoArticulo);
            this.Controls.Add(this.lblPrecioArticulo);
            this.Controls.Add(this.lblMarcaArticulo);
            this.Controls.Add(this.lblImgArticulo);
            this.Controls.Add(this.lblCategoriaArticulo);
            this.Controls.Add(this.lblDescripcionArticulo);
            this.Controls.Add(this.lblNombreArticulo);
            this.Controls.Add(this.lblCodArticulo);
            this.Controls.Add(this.btnCancelarAgregado);
            this.Controls.Add(this.btnAgregarSecundario);
            this.Name = "frmAgregar";
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarSecundario;
        private System.Windows.Forms.Button btnCancelarAgregado;
        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private System.Windows.Forms.Label lblCategoriaArticulo;
        private System.Windows.Forms.Label lblImgArticulo;
        private System.Windows.Forms.Label lblMarcaArticulo;
        private System.Windows.Forms.Label lblPrecioArticulo;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.TextBox txtDescripcionArticulo;
        private System.Windows.Forms.TextBox txtImagenArticulo;
        private System.Windows.Forms.ComboBox cboMarcaArticulo;
        private System.Windows.Forms.ComboBox cboCategoriaArticulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbxAgregarArticulo;
        private System.Windows.Forms.NumericUpDown numPrecio;
    }
}