namespace FrbaCrucero.CompraReservaPasaje
{
    partial class frmBusquedaPasaje
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaPartida = new System.Windows.Forms.DateTimePicker();
            this.cmbPuertoDestino = new System.Windows.Forms.ComboBox();
            this.cmbPuertoOrigen = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViajesDisponibles = new System.Windows.Forms.DataGridView();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViajesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaPartida);
            this.groupBox1.Controls.Add(this.cmbPuertoDestino);
            this.groupBox1.Controls.Add(this.cmbPuertoOrigen);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(356, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrado de Viajes:";
            // 
            // dtpFechaPartida
            // 
            this.dtpFechaPartida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPartida.Location = new System.Drawing.Point(145, 57);
            this.dtpFechaPartida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaPartida.Name = "dtpFechaPartida";
            this.dtpFechaPartida.Size = new System.Drawing.Size(136, 22);
            this.dtpFechaPartida.TabIndex = 6;
            // 
            // cmbPuertoDestino
            // 
            this.cmbPuertoDestino.FormattingEnabled = true;
            this.cmbPuertoDestino.Location = new System.Drawing.Point(145, 194);
            this.cmbPuertoDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuertoDestino.Name = "cmbPuertoDestino";
            this.cmbPuertoDestino.Size = new System.Drawing.Size(181, 24);
            this.cmbPuertoDestino.TabIndex = 5;
            // 
            // cmbPuertoOrigen
            // 
            this.cmbPuertoOrigen.FormattingEnabled = true;
            this.cmbPuertoOrigen.Location = new System.Drawing.Point(145, 121);
            this.cmbPuertoOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuertoOrigen.Name = "cmbPuertoOrigen";
            this.cmbPuertoOrigen.Size = new System.Drawing.Size(181, 24);
            this.cmbPuertoOrigen.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(111, 246);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(115, 48);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puerto Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerto de Origen:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Partida:";
            // 
            // dataGridViajesDisponibles
            // 
            this.dataGridViajesDisponibles.AllowUserToAddRows = false;
            this.dataGridViajesDisponibles.AllowUserToDeleteRows = false;
            this.dataGridViajesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViajesDisponibles.Location = new System.Drawing.Point(424, 47);
            this.dataGridViajesDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViajesDisponibles.MultiSelect = false;
            this.dataGridViajesDisponibles.Name = "dataGridViajesDisponibles";
            this.dataGridViajesDisponibles.RowHeadersVisible = false;
            this.dataGridViajesDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViajesDisponibles.Size = new System.Drawing.Size(1536, 466);
            this.dataGridViajesDisponibles.TabIndex = 1;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(1757, 542);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(4);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(167, 59);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(1651, 542);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(162, 59);
            this.btnReservar.TabIndex = 5;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmBusquedaPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 654);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.dataGridViajesDisponibles);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBusquedaPasaje";
            this.Text = "Viajes Disponibles";
            this.Load += new System.EventHandler(this.frmBusquedaPasaje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViajesDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaPartida;
        private System.Windows.Forms.ComboBox cmbPuertoDestino;
        private System.Windows.Forms.ComboBox cmbPuertoOrigen;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViajesDisponibles;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnReservar;
    }
}