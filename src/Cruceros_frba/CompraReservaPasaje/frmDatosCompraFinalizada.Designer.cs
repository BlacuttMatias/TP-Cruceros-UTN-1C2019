namespace FrbaCrucero.CompraReservaPasaje
{
    partial class frmDatosCompraFinalizada
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
            this.dataGridDatosCompra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatosCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDatosCompra
            // 
            this.dataGridDatosCompra.AllowUserToAddRows = false;
            this.dataGridDatosCompra.AllowUserToDeleteRows = false;
            this.dataGridDatosCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatosCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDatosCompra.Location = new System.Drawing.Point(0, 0);
            this.dataGridDatosCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridDatosCompra.Name = "dataGridDatosCompra";
            this.dataGridDatosCompra.ReadOnly = true;
            this.dataGridDatosCompra.RowTemplate.Height = 24;
            this.dataGridDatosCompra.Size = new System.Drawing.Size(411, 192);
            this.dataGridDatosCompra.TabIndex = 0;
            // 
            // frmDatosCompraFinalizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 192);
            this.Controls.Add(this.dataGridDatosCompra);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDatosCompraFinalizada";
            this.Text = "Datos de la compra realizada";
            this.Load += new System.EventHandler(this.frmDatosCompraFinalizada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatosCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDatosCompra;
    }
}