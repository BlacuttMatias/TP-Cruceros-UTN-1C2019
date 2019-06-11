namespace FrbaCrucero.CompraReservaPasaje
{
    partial class frmTarjeta
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
            this.components = new System.ComponentModel.Container();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.lblCodigoVerificador = new System.Windows.Forms.Label();
            this.txtCodigoVerificador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.lblCantidadDeCuotas = new System.Windows.Forms.Label();
            this.cmbCantidadCuotas = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.toolTipNumeroTarjeta = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCodigoVerificador = new System.Windows.Forms.ToolTip(this.components);
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(42, 37);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(102, 17);
            this.lblNumeroTarjeta.TabIndex = 0;
            this.lblNumeroTarjeta.Text = "Numero tarjeta";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(213, 34);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(210, 22);
            this.txtNumeroTarjeta.TabIndex = 1;
            this.txtNumeroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTarjeta_KeyPress);
            // 
            // lblCodigoVerificador
            // 
            this.lblCodigoVerificador.AutoSize = true;
            this.lblCodigoVerificador.Location = new System.Drawing.Point(42, 87);
            this.lblCodigoVerificador.Name = "lblCodigoVerificador";
            this.lblCodigoVerificador.Size = new System.Drawing.Size(122, 17);
            this.lblCodigoVerificador.TabIndex = 2;
            this.lblCodigoVerificador.Text = "Codigo verificador";
            // 
            // txtCodigoVerificador
            // 
            this.txtCodigoVerificador.Location = new System.Drawing.Point(213, 82);
            this.txtCodigoVerificador.Name = "txtCodigoVerificador";
            this.txtCodigoVerificador.Size = new System.Drawing.Size(210, 22);
            this.txtCodigoVerificador.TabIndex = 3;
            this.txtCodigoVerificador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoVerificador_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(213, 132);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(210, 24);
            this.cmbEmpresa.TabIndex = 5;
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            // 
            // lblCantidadDeCuotas
            // 
            this.lblCantidadDeCuotas.AutoSize = true;
            this.lblCantidadDeCuotas.Location = new System.Drawing.Point(42, 191);
            this.lblCantidadDeCuotas.Name = "lblCantidadDeCuotas";
            this.lblCantidadDeCuotas.Size = new System.Drawing.Size(130, 17);
            this.lblCantidadDeCuotas.TabIndex = 6;
            this.lblCantidadDeCuotas.Text = "Cantidad de cuotas";
            // 
            // cmbCantidadCuotas
            // 
            this.cmbCantidadCuotas.FormattingEnabled = true;
            this.cmbCantidadCuotas.Location = new System.Drawing.Point(213, 184);
            this.cmbCantidadCuotas.Name = "cmbCantidadCuotas";
            this.cmbCantidadCuotas.Size = new System.Drawing.Size(210, 24);
            this.cmbCantidadCuotas.TabIndex = 7;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(500, 311);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(118, 35);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(29, 313);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(115, 33);
            this.btnAtras.TabIndex = 9;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(50, 243);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(131, 17);
            this.lblMontoTotal.TabIndex = 10;
            this.lblMontoTotal.Text = "Monto total a pagar";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(213, 238);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 22);
            this.txtMontoTotal.TabIndex = 11;
            // 
            // frmTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 382);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.cmbCantidadCuotas);
            this.Controls.Add(this.lblCantidadDeCuotas);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoVerificador);
            this.Controls.Add(this.lblCodigoVerificador);
            this.Controls.Add(this.txtNumeroTarjeta);
            this.Controls.Add(this.lblNumeroTarjeta);
            this.Name = "frmTarjeta";
            this.Text = "Ingreso datos de Tarjeta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTarjeta_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTarjeta_FormClosed);
            this.Load += new System.EventHandler(this.frmTarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.Label lblCodigoVerificador;
        private System.Windows.Forms.TextBox txtCodigoVerificador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label lblCantidadDeCuotas;
        private System.Windows.Forms.ComboBox cmbCantidadCuotas;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ToolTip toolTipNumeroTarjeta;
        private System.Windows.Forms.ToolTip toolTipCodigoVerificador;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.TextBox txtMontoTotal;
    }
}