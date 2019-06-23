namespace FrbaCrucero.AbmCrucero
{
    partial class frmModificacionCrucero
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gBoxFiltros = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxFiltroID = new System.Windows.Forms.TextBox();
            this.lblFiltroDestino = new System.Windows.Forms.Label();
            this.lblFiltroOrigen = new System.Windows.Forms.Label();
            this.txtBoxFiltroMarca = new System.Windows.Forms.TextBox();
            this.txtBoxFiltroModelo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(713, 440);
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
            this.btnLimpiar.Location = new System.Drawing.Point(12, 440);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 345);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(770, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // gBoxFiltros
            // 
            this.gBoxFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxFiltros.Controls.Add(this.label2);
            this.gBoxFiltros.Controls.Add(this.txtBoxFiltroID);
            this.gBoxFiltros.Controls.Add(this.lblFiltroDestino);
            this.gBoxFiltros.Controls.Add(this.lblFiltroOrigen);
            this.gBoxFiltros.Controls.Add(this.txtBoxFiltroMarca);
            this.gBoxFiltros.Controls.Add(this.txtBoxFiltroModelo);
            this.gBoxFiltros.Location = new System.Drawing.Point(15, -2);
            this.gBoxFiltros.Name = "gBoxFiltros";
            this.gBoxFiltros.Size = new System.Drawing.Size(773, 88);
            this.gBoxFiltros.TabIndex = 9;
            this.gBoxFiltros.TabStop = false;
            this.gBoxFiltros.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Codigo";
            // 
            // txtBoxFiltroID
            // 
            this.txtBoxFiltroID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFiltroID.Location = new System.Drawing.Point(87, 17);
            this.txtBoxFiltroID.MaximumSize = new System.Drawing.Size(187, 20);
            this.txtBoxFiltroID.MinimumSize = new System.Drawing.Size(167, 20);
            this.txtBoxFiltroID.Name = "txtBoxFiltroID";
            this.txtBoxFiltroID.Size = new System.Drawing.Size(187, 20);
            this.txtBoxFiltroID.TabIndex = 12;
            this.txtBoxFiltroID.TextChanged += new System.EventHandler(this.txtBoxFiltroID_TextChanged);
            // 
            // lblFiltroDestino
            // 
            this.lblFiltroDestino.AutoSize = true;
            this.lblFiltroDestino.Location = new System.Drawing.Point(14, 62);
            this.lblFiltroDestino.Name = "lblFiltroDestino";
            this.lblFiltroDestino.Size = new System.Drawing.Size(77, 13);
            this.lblFiltroDestino.TabIndex = 9;
            this.lblFiltroDestino.Text = "Filtro Modelo";
            // 
            // lblFiltroOrigen
            // 
            this.lblFiltroOrigen.AutoSize = true;
            this.lblFiltroOrigen.Location = new System.Drawing.Point(303, 20);
            this.lblFiltroOrigen.Name = "lblFiltroOrigen";
            this.lblFiltroOrigen.Size = new System.Drawing.Size(68, 13);
            this.lblFiltroOrigen.TabIndex = 8;
            this.lblFiltroOrigen.Text = "Filtro Marca";
            // 
            // txtBoxFiltroMarca
            // 
            this.txtBoxFiltroMarca.Location = new System.Drawing.Point(371, 17);
            this.txtBoxFiltroMarca.MaximumSize = new System.Drawing.Size(200, 20);
            this.txtBoxFiltroMarca.MinimumSize = new System.Drawing.Size(200, 20);
            this.txtBoxFiltroMarca.Name = "txtBoxFiltroMarca";
            this.txtBoxFiltroMarca.Size = new System.Drawing.Size(200, 20);
            this.txtBoxFiltroMarca.TabIndex = 5;
            this.txtBoxFiltroMarca.TextChanged += new System.EventHandler(this.txtBoxFiltroMarca_TextChanged);
            // 
            // txtBoxFiltroModelo
            // 
            this.txtBoxFiltroModelo.Location = new System.Drawing.Point(87, 59);
            this.txtBoxFiltroModelo.MaximumSize = new System.Drawing.Size(187, 20);
            this.txtBoxFiltroModelo.MinimumSize = new System.Drawing.Size(187, 20);
            this.txtBoxFiltroModelo.Name = "txtBoxFiltroModelo";
            this.txtBoxFiltroModelo.Size = new System.Drawing.Size(187, 20);
            this.txtBoxFiltroModelo.TabIndex = 7;
            this.txtBoxFiltroModelo.TextChanged += new System.EventHandler(this.txtBoxFiltroModelo_TextChanged);
            // 
            // frmModificacionCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.gBoxFiltros);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(816, 513);
            this.Name = "frmModificacionCrucero";
            this.Text = "ABM Crucero";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBoxFiltros.ResumeLayout(false);
            this.gBoxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gBoxFiltros;
        private System.Windows.Forms.Label lblFiltroDestino;
        private System.Windows.Forms.Label lblFiltroOrigen;
        private System.Windows.Forms.TextBox txtBoxFiltroMarca;
        private System.Windows.Forms.TextBox txtBoxFiltroModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxFiltroID;
    }
}