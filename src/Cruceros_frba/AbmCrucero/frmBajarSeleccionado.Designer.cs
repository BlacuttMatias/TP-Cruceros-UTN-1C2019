namespace FrbaCrucero.AbmCrucero
{
    partial class frmBajarSeleccionado
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTipoBaja = new System.Windows.Forms.Label();
            this.dtpBaja = new System.Windows.Forms.DateTimePicker();
            this.dtpAlta = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblTipoBaja
            // 
            this.lblTipoBaja.AutoSize = true;
            this.lblTipoBaja.Location = new System.Drawing.Point(12, 41);
            this.lblTipoBaja.Name = "lblTipoBaja";
            this.lblTipoBaja.Size = new System.Drawing.Size(67, 13);
            this.lblTipoBaja.TabIndex = 1;
            this.lblTipoBaja.Text = "Tipo de Baja";
            // 
            // dtpBaja
            // 
            this.dtpBaja.Location = new System.Drawing.Point(85, 76);
            this.dtpBaja.Name = "dtpBaja";
            this.dtpBaja.Size = new System.Drawing.Size(200, 20);
            this.dtpBaja.TabIndex = 2;
            // 
            // dtpAlta
            // 
            this.dtpAlta.Location = new System.Drawing.Point(85, 115);
            this.dtpAlta.Name = "dtpAlta";
            this.dtpAlta.Size = new System.Drawing.Size(200, 20);
            this.dtpAlta.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(210, 141);
            this.btnAceptar.MaximumSize = new System.Drawing.Size(75, 23);
            this.btnAceptar.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(15, 141);
            this.btnLimpiar.MaximumSize = new System.Drawing.Size(75, 23);
            this.btnLimpiar.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha Baja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha Alta";
            // 
            // frmBajarSeleccionado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 174);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtpAlta);
            this.Controls.Add(this.dtpBaja);
            this.Controls.Add(this.lblTipoBaja);
            this.Controls.Add(this.lblCodigo);
            this.MaximumSize = new System.Drawing.Size(309, 212);
            this.MinimumSize = new System.Drawing.Size(309, 212);
            this.Name = "frmBajarSeleccionado";
            this.Text = "frmBajarSeleccionado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTipoBaja;
        private System.Windows.Forms.DateTimePicker dtpBaja;
        private System.Windows.Forms.DateTimePicker dtpAlta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}