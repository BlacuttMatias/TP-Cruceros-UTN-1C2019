﻿namespace FrbaCrucero.CompraReservaPasaje
{
    partial class frmCabinasDisponibles
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
            this.label1 = new System.Windows.Forms.Label();
            this.Reservar = new System.Windows.Forms.Button();
            this.cabinasDisponibles = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cabinasDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cabinasDisponibles);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione las cabinas que desea comprar: *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "* Para seleccionar multiples cabinas mantenga presionada la tecla Ctrl.";
            // 
            // Reservar
            // 
            this.Reservar.Location = new System.Drawing.Point(421, 220);
            this.Reservar.Name = "Reservar";
            this.Reservar.Size = new System.Drawing.Size(85, 32);
            this.Reservar.TabIndex = 2;
            this.Reservar.Text = "Comprar";
            this.Reservar.UseVisualStyleBackColor = true;
            this.Reservar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cabinasDisponibles
            // 
            this.cabinasDisponibles.AllowUserToAddRows = false;
            this.cabinasDisponibles.AllowUserToDeleteRows = false;
            this.cabinasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cabinasDisponibles.Location = new System.Drawing.Point(9, 19);
            this.cabinasDisponibles.MultiSelect = false;
            this.cabinasDisponibles.Name = "cabinasDisponibles";
            this.cabinasDisponibles.RowHeadersVisible = false;
            this.cabinasDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cabinasDisponibles.Size = new System.Drawing.Size(518, 178);
            this.cabinasDisponibles.TabIndex = 0;
            // 
            // frmCabinasDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 262);
            this.Controls.Add(this.Reservar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCabinasDisponibles";
            this.Text = "Cabinas disponibles para su viaje";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cabinasDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView cabinasDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reservar;
    }
}