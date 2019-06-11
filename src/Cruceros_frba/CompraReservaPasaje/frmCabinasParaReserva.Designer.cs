namespace FrbaCrucero.CompraReservaPasaje
{
    partial class frmCabinasParaReserva
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
            this.brnReservar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridCabinasDisponibles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCabinasDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // brnReservar
            // 
            this.brnReservar.Location = new System.Drawing.Point(452, 272);
            this.brnReservar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brnReservar.Name = "brnReservar";
            this.brnReservar.Size = new System.Drawing.Size(143, 39);
            this.brnReservar.TabIndex = 4;
            this.brnReservar.Text = "Reservar Cabina";
            this.brnReservar.UseVisualStyleBackColor = true;
            this.brnReservar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridCabinasDisponibles);
            this.groupBox1.Location = new System.Drawing.Point(4, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(716, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la cabina que desea reservar: *";
            // 
            // dataGridCabinasDisponibles
            // 
            this.dataGridCabinasDisponibles.AllowUserToAddRows = false;
            this.dataGridCabinasDisponibles.AllowUserToDeleteRows = false;
            this.dataGridCabinasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCabinasDisponibles.Location = new System.Drawing.Point(12, 23);
            this.dataGridCabinasDisponibles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridCabinasDisponibles.MultiSelect = false;
            this.dataGridCabinasDisponibles.Name = "dataGridCabinasDisponibles";
            this.dataGridCabinasDisponibles.RowHeadersVisible = false;
            this.dataGridCabinasDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCabinasDisponibles.Size = new System.Drawing.Size(691, 219);
            this.dataGridCabinasDisponibles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 284);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "* Las reservas se pueden realizar sobre una unica cabina.";
            // 
            // frmCabinasParaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brnReservar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCabinasParaReserva";
            this.Text = "Cabinas Para Reserva";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCabinasDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnReservar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridCabinasDisponibles;
        private System.Windows.Forms.Label label1;
    }
}