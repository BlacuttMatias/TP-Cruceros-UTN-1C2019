namespace FrbaCrucero.GeneracionViaje
{
    partial class frmGenerarViaje
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
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblCruceros = new System.Windows.Forms.Label();
            this.lblRecorrido = new System.Windows.Forms.Label();
            this.cmbRecorrido = new System.Windows.Forms.ComboBox();
            this.dataGridCruceros = new System.Windows.Forms.DataGridView();
            this.btnGenerarViaje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCruceros)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(275, 44);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(247, 22);
            this.dtpFechaInicio.TabIndex = 0;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(59, 49);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(103, 17);
            this.lblFechaInicio.TabIndex = 1;
            this.lblFechaInicio.Text = "Fecha de inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(61, 98);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(141, 17);
            this.lblFechaFin.TabIndex = 2;
            this.lblFechaFin.Text = "Fecha de finalización";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(275, 93);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(247, 22);
            this.dtpFechaFin.TabIndex = 3;
            // 
            // lblCruceros
            // 
            this.lblCruceros.AutoSize = true;
            this.lblCruceros.Location = new System.Drawing.Point(12, 150);
            this.lblCruceros.Name = "lblCruceros";
            this.lblCruceros.Size = new System.Drawing.Size(272, 17);
            this.lblCruceros.TabIndex = 4;
            this.lblCruceros.Text = "Cruceros disponibles para realizar el viaje";
            // 
            // lblRecorrido
            // 
            this.lblRecorrido.AutoSize = true;
            this.lblRecorrido.Location = new System.Drawing.Point(629, 49);
            this.lblRecorrido.Name = "lblRecorrido";
            this.lblRecorrido.Size = new System.Drawing.Size(70, 17);
            this.lblRecorrido.TabIndex = 5;
            this.lblRecorrido.Text = "Recorrido";
            // 
            // cmbRecorrido
            // 
            this.cmbRecorrido.FormattingEnabled = true;
            this.cmbRecorrido.Location = new System.Drawing.Point(720, 44);
            this.cmbRecorrido.Name = "cmbRecorrido";
            this.cmbRecorrido.Size = new System.Drawing.Size(298, 24);
            this.cmbRecorrido.TabIndex = 6;
            // 
            // dataGridCruceros
            // 
            this.dataGridCruceros.AllowUserToAddRows = false;
            this.dataGridCruceros.AllowUserToDeleteRows = false;
            this.dataGridCruceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCruceros.Location = new System.Drawing.Point(14, 185);
            this.dataGridCruceros.Name = "dataGridCruceros";
            this.dataGridCruceros.ReadOnly = true;
            this.dataGridCruceros.RowTemplate.Height = 24;
            this.dataGridCruceros.Size = new System.Drawing.Size(1021, 278);
            this.dataGridCruceros.TabIndex = 7;
            // 
            // btnGenerarViaje
            // 
            this.btnGenerarViaje.Location = new System.Drawing.Point(879, 528);
            this.btnGenerarViaje.Name = "btnGenerarViaje";
            this.btnGenerarViaje.Size = new System.Drawing.Size(139, 46);
            this.btnGenerarViaje.TabIndex = 8;
            this.btnGenerarViaje.Text = "Generar Viaje";
            this.btnGenerarViaje.UseVisualStyleBackColor = true;
            this.btnGenerarViaje.Click += new System.EventHandler(this.btnGenerarViaje_Click);
            // 
            // frmGenerarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 602);
            this.Controls.Add(this.btnGenerarViaje);
            this.Controls.Add(this.dataGridCruceros);
            this.Controls.Add(this.cmbRecorrido);
            this.Controls.Add(this.lblRecorrido);
            this.Controls.Add(this.lblCruceros);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaInicio);
            this.Name = "frmGenerarViaje";
            this.Text = "Generar Viaje";
            this.Load += new System.EventHandler(this.frmGenerarViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCruceros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblCruceros;
        private System.Windows.Forms.Label lblRecorrido;
        private System.Windows.Forms.ComboBox cmbRecorrido;
        private System.Windows.Forms.DataGridView dataGridCruceros;
        private System.Windows.Forms.Button btnGenerarViaje;
    }
}