namespace CapaPresentacion
{
    partial class frmAltaRecorrido
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
            this.lblPrecio = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPuertoOrigen = new System.Windows.Forms.Label();
            this.lblPuertoDestino = new System.Windows.Forms.Label();
            this.cmbPuertoOrigen = new System.Windows.Forms.ComboBox();
            this.cmbPuertoDestino = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(53, 46);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(210, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 27);
            this.textBox1.TabIndex = 1;
            // 
            // lblPuertoOrigen
            // 
            this.lblPuertoOrigen.AutoSize = true;
            this.lblPuertoOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuertoOrigen.Location = new System.Drawing.Point(53, 112);
            this.lblPuertoOrigen.Name = "lblPuertoOrigen";
            this.lblPuertoOrigen.Size = new System.Drawing.Size(109, 20);
            this.lblPuertoOrigen.TabIndex = 2;
            this.lblPuertoOrigen.Text = "Puerto origen";
            // 
            // lblPuertoDestino
            // 
            this.lblPuertoDestino.AutoSize = true;
            this.lblPuertoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuertoDestino.Location = new System.Drawing.Point(53, 180);
            this.lblPuertoDestino.Name = "lblPuertoDestino";
            this.lblPuertoDestino.Size = new System.Drawing.Size(117, 20);
            this.lblPuertoDestino.TabIndex = 3;
            this.lblPuertoDestino.Text = "Puerto destino";
            // 
            // cmbPuertoOrigen
            // 
            this.cmbPuertoOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuertoOrigen.FormattingEnabled = true;
            this.cmbPuertoOrigen.Location = new System.Drawing.Point(210, 104);
            this.cmbPuertoOrigen.Name = "cmbPuertoOrigen";
            this.cmbPuertoOrigen.Size = new System.Drawing.Size(136, 28);
            this.cmbPuertoOrigen.TabIndex = 4;
            // 
            // cmbPuertoDestino
            // 
            this.cmbPuertoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuertoDestino.FormattingEnabled = true;
            this.cmbPuertoDestino.Location = new System.Drawing.Point(210, 172);
            this.cmbPuertoDestino.Name = "cmbPuertoDestino";
            this.cmbPuertoDestino.Size = new System.Drawing.Size(136, 28);
            this.cmbPuertoDestino.TabIndex = 5;
            // 
            // frmAltaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 418);
            this.Controls.Add(this.cmbPuertoDestino);
            this.Controls.Add(this.cmbPuertoOrigen);
            this.Controls.Add(this.lblPuertoDestino);
            this.Controls.Add(this.lblPuertoOrigen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPrecio);
            this.Name = "frmAltaRecorrido";
            this.Text = "Alta Recorrido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPuertoOrigen;
        private System.Windows.Forms.Label lblPuertoDestino;
        private System.Windows.Forms.ComboBox cmbPuertoOrigen;
        private System.Windows.Forms.ComboBox cmbPuertoDestino;
    }
}