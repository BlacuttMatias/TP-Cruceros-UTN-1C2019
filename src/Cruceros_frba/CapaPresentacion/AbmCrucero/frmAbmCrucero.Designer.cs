﻿namespace CapaPresentacion
{
    partial class frmAbmCrucero
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificacionBaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione la operación que desea realizar";
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(55, 115);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(554, 56);
            this.btnAlta.TabIndex = 3;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificacionBaja
            // 
            this.btnModificacionBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificacionBaja.Location = new System.Drawing.Point(55, 237);
            this.btnModificacionBaja.Name = "btnModificacionBaja";
            this.btnModificacionBaja.Size = new System.Drawing.Size(554, 56);
            this.btnModificacionBaja.TabIndex = 5;
            this.btnModificacionBaja.Text = "Modificar o dar de baja";
            this.btnModificacionBaja.UseVisualStyleBackColor = true;
            this.btnModificacionBaja.Click += new System.EventHandler(this.btnModificacionBaja_Click);
            // 
            // frmAbmCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(675, 373);
            this.Controls.Add(this.btnModificacionBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.label1);
            this.Name = "frmAbmCrucero";
            this.Text = "ABM Crucero";
            this.Load += new System.EventHandler(this.frmAbmCrucero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificacionBaja;
    }
}