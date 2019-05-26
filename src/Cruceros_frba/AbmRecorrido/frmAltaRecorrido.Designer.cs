namespace FrbaCrucero.AbmRecorrido
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCrearTramo = new System.Windows.Forms.Button();
            this.txtBoxFiltroOrigen = new System.Windows.Forms.TextBox();
            this.txtBoxFiltroDestino = new System.Windows.Forms.TextBox();
            this.gBoxFiltros = new System.Windows.Forms.GroupBox();
            this.lblFiltroDestino = new System.Windows.Forms.Label();
            this.lblFiltroOrigen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 311F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 116);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1095, 370);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(790, 6);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 358);
            this.listBox1.TabIndex = 5;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(772, 358);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(15, 69);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(65, 25);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(265, 9);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(76, 25);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(15, 9);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(70, 25);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(6, 495);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 38);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.Location = new System.Drawing.Point(979, 495);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(110, 38);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Aceptar";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCrearTramo
            // 
            this.btnCrearTramo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearTramo.Location = new System.Drawing.Point(715, 495);
            this.btnCrearTramo.Name = "btnCrearTramo";
            this.btnCrearTramo.Size = new System.Drawing.Size(134, 38);
            this.btnCrearTramo.TabIndex = 4;
            this.btnCrearTramo.Text = "NuevoTramo";
            this.btnCrearTramo.UseVisualStyleBackColor = true;
            this.btnCrearTramo.Click += new System.EventHandler(this.btnCrearTramo_Click);
            // 
            // txtBoxFiltroOrigen
            // 
            this.txtBoxFiltroOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFiltroOrigen.Location = new System.Drawing.Point(177, 18);
            this.txtBoxFiltroOrigen.Name = "txtBoxFiltroOrigen";
            this.txtBoxFiltroOrigen.Size = new System.Drawing.Size(339, 32);
            this.txtBoxFiltroOrigen.TabIndex = 5;
            // 
            // txtBoxFiltroDestino
            // 
            this.txtBoxFiltroDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFiltroDestino.Location = new System.Drawing.Point(177, 56);
            this.txtBoxFiltroDestino.Name = "txtBoxFiltroDestino";
            this.txtBoxFiltroDestino.Size = new System.Drawing.Size(339, 32);
            this.txtBoxFiltroDestino.TabIndex = 7;
            // 
            // gBoxFiltros
            // 
            this.gBoxFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxFiltros.Controls.Add(this.lblFiltroDestino);
            this.gBoxFiltros.Controls.Add(this.lblFiltroOrigen);
            this.gBoxFiltros.Controls.Add(this.txtBoxFiltroOrigen);
            this.gBoxFiltros.Controls.Add(this.txtBoxFiltroDestino);
            this.gBoxFiltros.Location = new System.Drawing.Point(562, 6);
            this.gBoxFiltros.Name = "gBoxFiltros";
            this.gBoxFiltros.Size = new System.Drawing.Size(522, 88);
            this.gBoxFiltros.TabIndex = 8;
            this.gBoxFiltros.TabStop = false;
            this.gBoxFiltros.Text = "Filtros";
            // 
            // lblFiltroDestino
            // 
            this.lblFiltroDestino.AutoSize = true;
            this.lblFiltroDestino.Location = new System.Drawing.Point(53, 59);
            this.lblFiltroDestino.Name = "lblFiltroDestino";
            this.lblFiltroDestino.Size = new System.Drawing.Size(124, 25);
            this.lblFiltroDestino.TabIndex = 9;
            this.lblFiltroDestino.Text = "Filtro Destino";
            // 
            // lblFiltroOrigen
            // 
            this.lblFiltroOrigen.AutoSize = true;
            this.lblFiltroOrigen.Location = new System.Drawing.Point(53, 21);
            this.lblFiltroOrigen.Name = "lblFiltroOrigen";
            this.lblFiltroOrigen.Size = new System.Drawing.Size(118, 25);
            this.lblFiltroOrigen.TabIndex = 8;
            this.lblFiltroOrigen.Text = "Filtro Origen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Click para borrar Ultimo Tramo";
            // 
            // frmAltaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBoxFiltros);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnCrearTramo);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(963, 525);
            this.Name = "frmAltaRecorrido";
            this.Text = "ABM Alta Recorrido";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBoxFiltros.ResumeLayout(false);
            this.gBoxFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCrearTramo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxFiltroOrigen;
        private System.Windows.Forms.TextBox txtBoxFiltroDestino;
        private System.Windows.Forms.GroupBox gBoxFiltros;
        private System.Windows.Forms.Label lblFiltroDestino;
        private System.Windows.Forms.Label lblFiltroOrigen;
        private System.Windows.Forms.Label label1;
    }
}