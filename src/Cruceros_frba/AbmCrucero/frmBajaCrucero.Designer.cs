namespace FrbaCrucero.AbmCrucero
{
    partial class frmBajaCrucero
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvCruceros = new System.Windows.Forms.DataGridView();
            this.gBoxFiltros = new System.Windows.Forms.GroupBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxFiltroCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBajas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCruceros)).BeginInit();
            this.gBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(713, 459);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 459);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvCruceros
            // 
            this.dgvCruceros.AllowUserToAddRows = false;
            this.dgvCruceros.AllowUserToDeleteRows = false;
            this.dgvCruceros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCruceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCruceros.Location = new System.Drawing.Point(15, 73);
            this.dgvCruceros.Name = "dgvCruceros";
            this.dgvCruceros.ReadOnly = true;
            this.dgvCruceros.Size = new System.Drawing.Size(773, 176);
            this.dgvCruceros.TabIndex = 0;
            // 
            // gBoxFiltros
            // 
            this.gBoxFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxFiltros.Controls.Add(this.tbModelo);
            this.gBoxFiltros.Controls.Add(this.label5);
            this.gBoxFiltros.Controls.Add(this.tbMarca);
            this.gBoxFiltros.Controls.Add(this.lblMarca);
            this.gBoxFiltros.Controls.Add(this.label2);
            this.gBoxFiltros.Controls.Add(this.txtBoxFiltroCodigo);
            this.gBoxFiltros.Location = new System.Drawing.Point(15, -2);
            this.gBoxFiltros.Name = "gBoxFiltros";
            this.gBoxFiltros.Size = new System.Drawing.Size(773, 52);
            this.gBoxFiltros.TabIndex = 9;
            this.gBoxFiltros.TabStop = false;
            this.gBoxFiltros.Text = "Filtros";
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(546, 20);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(186, 20);
            this.tbModelo.TabIndex = 20;
            this.tbModelo.TextChanged += new System.EventHandler(this.tbModelo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Modelo";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(296, 17);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(186, 20);
            this.tbMarca.TabIndex = 15;
            this.tbMarca.TextChanged += new System.EventHandler(this.tbMarca_TextChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(250, 20);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Codigo";
            // 
            // txtBoxFiltroCodigo
            // 
            this.txtBoxFiltroCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFiltroCodigo.Location = new System.Drawing.Point(60, 17);
            this.txtBoxFiltroCodigo.MaximumSize = new System.Drawing.Size(186, 20);
            this.txtBoxFiltroCodigo.MinimumSize = new System.Drawing.Size(167, 20);
            this.txtBoxFiltroCodigo.Name = "txtBoxFiltroCodigo";
            this.txtBoxFiltroCodigo.Size = new System.Drawing.Size(186, 20);
            this.txtBoxFiltroCodigo.TabIndex = 12;
            this.txtBoxFiltroCodigo.TextChanged += new System.EventHandler(this.txtBoxFiltroCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cruceros Habilitados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bajas Registradas";
            // 
            // dgvBajas
            // 
            this.dgvBajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBajas.Location = new System.Drawing.Point(15, 274);
            this.dgvBajas.Name = "dgvBajas";
            this.dgvBajas.Size = new System.Drawing.Size(773, 157);
            this.dgvBajas.TabIndex = 13;
            // 
            // frmBajaCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.dgvBajas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCruceros);
            this.Controls.Add(this.gBoxFiltros);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.MinimumSize = new System.Drawing.Size(816, 513);
            this.Name = "frmBajaCrucero";
            this.Text = "ABM Crucero";
            this.Activated += new System.EventHandler(this.frmModificacionCrucero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCruceros)).EndInit();
            this.gBoxFiltros.ResumeLayout(false);
            this.gBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvCruceros;
        private System.Windows.Forms.GroupBox gBoxFiltros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxFiltroCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBajas;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label lblMarca;
    }
}