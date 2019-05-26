namespace FrbaCrucero.AbmRecorrido
{
    partial class frmNuevoTramo
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
            this.cBoxOrigen = new System.Windows.Forms.ComboBox();
            this.cBoxDestino = new System.Windows.Forms.ComboBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBoxOrigen
            // 
            this.cBoxOrigen.FormattingEnabled = true;
            this.cBoxOrigen.Location = new System.Drawing.Point(150, 23);
            this.cBoxOrigen.Margin = new System.Windows.Forms.Padding(6);
            this.cBoxOrigen.Name = "cBoxOrigen";
            this.cBoxOrigen.Size = new System.Drawing.Size(219, 33);
            this.cBoxOrigen.TabIndex = 0;
            // 
            // cBoxDestino
            // 
            this.cBoxDestino.FormattingEnabled = true;
            this.cBoxDestino.Location = new System.Drawing.Point(150, 84);
            this.cBoxDestino.Margin = new System.Windows.Forms.Padding(6);
            this.cBoxDestino.Name = "cBoxDestino";
            this.cBoxDestino.Size = new System.Drawing.Size(219, 33);
            this.cBoxDestino.TabIndex = 1;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(50, 29);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(70, 25);
            this.lblOrigen.TabIndex = 2;
            this.lblOrigen.Text = "Origen";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(50, 87);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(76, 25);
            this.lblDestino.TabIndex = 3;
            this.lblDestino.Text = "Destino";
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Location = new System.Drawing.Point(504, 24);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(100, 32);
            this.txtBoxPrecio.TabIndex = 4;
            this.txtBoxPrecio.TextChanged += new System.EventHandler(this.txtBoxPrecio_TextChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(433, 26);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(65, 25);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(479, 84);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 39);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmNuevoTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 135);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.cBoxDestino);
            this.Controls.Add(this.cBoxOrigen);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmNuevoTramo";
            this.Text = "frmNuevoTramo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxOrigen;
        private System.Windows.Forms.ComboBox cBoxDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAceptar;
    }
}