namespace FrbaCrucero.AbmCrucero
{
    partial class frmCopiarCrucero
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
            this.lblViejo = new System.Windows.Forms.Label();
            this.lblCruceroNuevo = new System.Windows.Forms.Label();
            this.txtBoxCrucero = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblViejo
            // 
            this.lblViejo.AutoSize = true;
            this.lblViejo.Location = new System.Drawing.Point(16, 11);
            this.lblViejo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViejo.Name = "lblViejo";
            this.lblViejo.Size = new System.Drawing.Size(151, 17);
            this.lblViejo.TabIndex = 0;
            this.lblViejo.Text = "Crucero A Reemplazar";
            // 
            // lblCruceroNuevo
            // 
            this.lblCruceroNuevo.AutoSize = true;
            this.lblCruceroNuevo.Location = new System.Drawing.Point(16, 54);
            this.lblCruceroNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCruceroNuevo.Name = "lblCruceroNuevo";
            this.lblCruceroNuevo.Size = new System.Drawing.Size(97, 17);
            this.lblCruceroNuevo.TabIndex = 1;
            this.lblCruceroNuevo.Text = "Nuevo Codigo";
            // 
            // txtBoxCrucero
            // 
            this.txtBoxCrucero.Location = new System.Drawing.Point(124, 50);
            this.txtBoxCrucero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCrucero.Name = "txtBoxCrucero";
            this.txtBoxCrucero.Size = new System.Drawing.Size(169, 22);
            this.txtBoxCrucero.TabIndex = 2;
            this.txtBoxCrucero.TextChanged += new System.EventHandler(this.txtBoxCrucero_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(342, 111);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(95, 111);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ej: ABCDEF-12345";
            // 
            // frmCopiarCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 154);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtBoxCrucero);
            this.Controls.Add(this.lblCruceroNuevo);
            this.Controls.Add(this.lblViejo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCopiarCrucero";
            this.Text = "Alta nuevo Crucero igual al anterior";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViejo;
        private System.Windows.Forms.Label lblCruceroNuevo;
        private System.Windows.Forms.TextBox txtBoxCrucero;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
    }
}