namespace FrbaCrucero.ListadoEstadistico
{
    partial class frmListadosEstadisticos
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
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.cmbTipoListado = new System.Windows.Forms.ComboBox();
            this.lblTipoListado = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dataGridListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListado)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(12, 56);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(121, 24);
            this.cmbAnio.TabIndex = 0;
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Location = new System.Drawing.Point(175, 56);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(121, 24);
            this.cmbSemestre.TabIndex = 1;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(12, 27);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(33, 17);
            this.lblAnio.TabIndex = 2;
            this.lblAnio.Text = "Año";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(172, 27);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(68, 17);
            this.lblSemestre.TabIndex = 3;
            this.lblSemestre.Text = "Semestre";
            // 
            // cmbTipoListado
            // 
            this.cmbTipoListado.FormattingEnabled = true;
            this.cmbTipoListado.Location = new System.Drawing.Point(338, 56);
            this.cmbTipoListado.Name = "cmbTipoListado";
            this.cmbTipoListado.Size = new System.Drawing.Size(352, 24);
            this.cmbTipoListado.TabIndex = 4;
            // 
            // lblTipoListado
            // 
            this.lblTipoListado.AutoSize = true;
            this.lblTipoListado.Location = new System.Drawing.Point(335, 27);
            this.lblTipoListado.Name = "lblTipoListado";
            this.lblTipoListado.Size = new System.Drawing.Size(101, 17);
            this.lblTipoListado.TabIndex = 5;
            this.lblTipoListado.Text = "Tipo de listado";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(728, 51);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(144, 33);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar Listado";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dataGridListado
            // 
            this.dataGridListado.AllowUserToAddRows = false;
            this.dataGridListado.AllowUserToDeleteRows = false;
            this.dataGridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListado.Location = new System.Drawing.Point(12, 130);
            this.dataGridListado.Name = "dataGridListado";
            this.dataGridListado.ReadOnly = true;
            this.dataGridListado.RowTemplate.Height = 24;
            this.dataGridListado.Size = new System.Drawing.Size(1953, 354);
            this.dataGridListado.TabIndex = 7;
            // 
            // frmListadosEstadisticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 591);
            this.Controls.Add(this.dataGridListado);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblTipoListado);
            this.Controls.Add(this.cmbTipoListado);
            this.Controls.Add(this.lblSemestre);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.cmbSemestre);
            this.Controls.Add(this.cmbAnio);
            this.Name = "frmListadosEstadisticos";
            this.Text = "Listado estadístico";
            this.Load += new System.EventHandler(this.frmListadosEstadisticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.ComboBox cmbTipoListado;
        private System.Windows.Forms.Label lblTipoListado;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dataGridListado;

    }
}