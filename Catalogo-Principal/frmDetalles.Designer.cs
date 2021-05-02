
namespace Catalogo_Principal
{
    partial class frmDetalles
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
            this.dvgDetalles = new System.Windows.Forms.DataGridView();
            this.pbxDetalles = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgDetalles
            // 
            this.dvgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDetalles.Location = new System.Drawing.Point(12, 48);
            this.dvgDetalles.Name = "dvgDetalles";
            this.dvgDetalles.Size = new System.Drawing.Size(663, 62);
            this.dvgDetalles.TabIndex = 0;
            // 
            // pbxDetalles
            // 
            this.pbxDetalles.Location = new System.Drawing.Point(212, 129);
            this.pbxDetalles.Name = "pbxDetalles";
            this.pbxDetalles.Size = new System.Drawing.Size(244, 235);
            this.pbxDetalles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDetalles.TabIndex = 1;
            this.pbxDetalles.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "DETALLES";
            // 
            // frmDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(235)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(687, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxDetalles);
            this.Controls.Add(this.dvgDetalles);
            this.Name = "frmDetalles";
            this.Text = "Detalles";
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgDetalles;
        private System.Windows.Forms.PictureBox pbxDetalles;
        private System.Windows.Forms.Label label1;
    }
}