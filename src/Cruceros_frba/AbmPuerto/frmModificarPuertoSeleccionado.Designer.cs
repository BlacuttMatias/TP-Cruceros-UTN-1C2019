namespace FrbaCrucero.AbmPuerto
{
    partial class frmModificarPuertoSeleccionado
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.ckBoxHabilitado = new System.Windows.Forms.CheckBox();
            this.txtBoxCiudad = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblErrorCiudad = new System.Windows.Forms.Label();
            this.lblErrorDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(343, 200);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(138, 44);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Aceptar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ckBoxHabilitado
            // 
            this.ckBoxHabilitado.AutoSize = true;
            this.ckBoxHabilitado.Location = new System.Drawing.Point(140, 155);
            this.ckBoxHabilitado.Margin = new System.Windows.Forms.Padding(6);
            this.ckBoxHabilitado.Name = "ckBoxHabilitado";
            this.ckBoxHabilitado.Size = new System.Drawing.Size(118, 29);
            this.ckBoxHabilitado.TabIndex = 2;
            this.ckBoxHabilitado.Text = "Habilitado";
            this.ckBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtBoxCiudad
            // 
            this.txtBoxCiudad.Location = new System.Drawing.Point(140, 55);
            this.txtBoxCiudad.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxCiudad.Name = "txtBoxCiudad";
            this.txtBoxCiudad.Size = new System.Drawing.Size(266, 32);
            this.txtBoxCiudad.TabIndex = 3;
            this.txtBoxCiudad.TextChanged += new System.EventHandler(this.txtBoxCiudad_TextChanged);
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(139, 111);
            this.txtBoxDescripcion.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(267, 32);
            this.txtBoxDescripcion.TabIndex = 4;
            this.txtBoxDescripcion.TextChanged += new System.EventHandler(this.txtBoxDescripcion_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(135, 24);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(68, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Puerto";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(16, 62);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(72, 25);
            this.lblCiudad.TabIndex = 6;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 111);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(111, 25);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblErrorCiudad
            // 
            this.lblErrorCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCiudad.AutoSize = true;
            this.lblErrorCiudad.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCiudad.Location = new System.Drawing.Point(408, 58);
            this.lblErrorCiudad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblErrorCiudad.Name = "lblErrorCiudad";
            this.lblErrorCiudad.Size = new System.Drawing.Size(20, 25);
            this.lblErrorCiudad.TabIndex = 8;
            this.lblErrorCiudad.Text = "*";
            // 
            // lblErrorDescripcion
            // 
            this.lblErrorDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorDescripcion.AutoSize = true;
            this.lblErrorDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDescripcion.Location = new System.Drawing.Point(408, 114);
            this.lblErrorDescripcion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblErrorDescripcion.Name = "lblErrorDescripcion";
            this.lblErrorDescripcion.Size = new System.Drawing.Size(20, 25);
            this.lblErrorDescripcion.TabIndex = 9;
            this.lblErrorDescripcion.Text = "*";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(56, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Llene los campos requeridos";
            // 
            // frmModificarPuertoSeleccionado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorDescripcion);
            this.Controls.Add(this.lblErrorCiudad);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.txtBoxCiudad);
            this.Controls.Add(this.ckBoxHabilitado);
            this.Controls.Add(this.btnModificar);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmModificarPuertoSeleccionado";
            this.Text = "Puertos Bajas y Modificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.CheckBox ckBoxHabilitado;
        private System.Windows.Forms.TextBox txtBoxCiudad;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblErrorCiudad;
        private System.Windows.Forms.Label lblErrorDescripcion;
        private System.Windows.Forms.Label label1;
    }
}