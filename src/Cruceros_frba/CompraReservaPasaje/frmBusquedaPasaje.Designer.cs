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
            this.groupBox1.Location = new System.Drawing.Point(25, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrado de Viajes:";
            // 
            // dtpFechaPartida
            // 
            this.dtpFechaPartida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPartida.Location = new System.Drawing.Point(109, 46);
            this.dtpFechaPartida.Name = "dtpFechaPartida";
            this.dtpFechaPartida.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaPartida.TabIndex = 6;
            // 
            // cmbPuertoDestino
            // 
            this.cmbPuertoDestino.FormattingEnabled = true;
            this.cmbPuertoDestino.Location = new System.Drawing.Point(109, 158);
            this.cmbPuertoDestino.Name = "cmbPuertoDestino";
            this.cmbPuertoDestino.Size = new System.Drawing.Size(137, 21);
            this.cmbPuertoDestino.TabIndex = 5;
            // 
            // cmbPuertoOrigen
            // 
            this.cmbPuertoOrigen.FormattingEnabled = true;
            this.cmbPuertoOrigen.Location = new System.Drawing.Point(109, 98);
            this.cmbPuertoOrigen.Name = "cmbPuertoOrigen";
            this.cmbPuertoOrigen.Size = new System.Drawing.Size(137, 21);
            this.cmbPuertoOrigen.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(83, 200);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(86, 39);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puerto Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerto de Origen:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Partida:";
            // 
            // dataGridViajesDisponibles
            // 
            this.dataGridViajesDisponibles.AllowUserToAddRows = false;
            this.dataGridViajesDisponibles.AllowUserToDeleteRows = false;
            this.dataGridViajesDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViajesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViajesDisponibles.Location = new System.Drawing.Point(298, 29);
            this.dataGridViajesDisponibles.MultiSelect = false;
            this.dataGridViajesDisponibles.Name = "dataGridViajesDisponibles";
            this.dataGridViajesDisponibles.RowHeadersVisible = false;
            this.dataGridViajesDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViajesDisponibles.Size = new System.Drawing.Size(574, 379);
            this.dataGridViajesDisponibles.TabIndex = 1;
            // 
            // btnComprar
            // 
            this.btnComprar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComprar.Location = new System.Drawing.Point(747, 424);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(125, 48);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservar.Location = new System.Drawing.Point(619, 424);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(122, 48);
            this.btnReservar.TabIndex = 5;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmBusquedaPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 487);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.dataGridViajesDisponibles);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(900, 525);
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