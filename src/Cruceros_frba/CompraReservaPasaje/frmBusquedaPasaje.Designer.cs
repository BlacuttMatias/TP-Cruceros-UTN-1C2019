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
            this.fechaPartida = new System.Windows.Forms.DateTimePicker();
            this.puertoDestino = new System.Windows.Forms.ComboBox();
            this.puertoOrigen = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViajesDisponibles = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViajesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechaPartida);
            this.groupBox1.Controls.Add(this.puertoDestino);
            this.groupBox1.Controls.Add(this.puertoOrigen);
            this.groupBox1.Controls.Add(this.button1);
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
            // fechaPartida
            // 
            this.fechaPartida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaPartida.Location = new System.Drawing.Point(109, 46);
            this.fechaPartida.Name = "fechaPartida";
            this.fechaPartida.Size = new System.Drawing.Size(103, 20);
            this.fechaPartida.TabIndex = 6;
            // 
            // puertoDestino
            // 
            this.puertoDestino.FormattingEnabled = true;
            this.puertoDestino.Location = new System.Drawing.Point(109, 158);
            this.puertoDestino.Name = "puertoDestino";
            this.puertoDestino.Size = new System.Drawing.Size(137, 21);
            this.puertoDestino.TabIndex = 5;
            // 
            // puertoOrigen
            // 
            this.puertoOrigen.FormattingEnabled = true;
            this.puertoOrigen.Location = new System.Drawing.Point(109, 98);
            this.puertoOrigen.Name = "puertoOrigen";
            this.puertoOrigen.Size = new System.Drawing.Size(137, 21);
            this.puertoOrigen.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(83, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridViajesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViajesDisponibles.Location = new System.Drawing.Point(318, 38);
            this.dataGridViajesDisponibles.MultiSelect = false;
            this.dataGridViajesDisponibles.Name = "dataGridViajesDisponibles";
            this.dataGridViajesDisponibles.RowHeadersVisible = false;
            this.dataGridViajesDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViajesDisponibles.Size = new System.Drawing.Size(365, 214);
            this.dataGridViajesDisponibles.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Comprar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(525, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "Reservar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmBusquedaPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 300);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViajesDisponibles);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.DateTimePicker fechaPartida;
        private System.Windows.Forms.ComboBox puertoDestino;
        private System.Windows.Forms.ComboBox puertoOrigen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViajesDisponibles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}