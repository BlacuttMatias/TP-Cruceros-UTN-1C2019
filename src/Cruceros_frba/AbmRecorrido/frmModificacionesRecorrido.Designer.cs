namespace FrbaCrucero.AbmRecorrido
{
    partial class frmModificacionesRecorrido
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFiltroPrecio = new System.Windows.Forms.TextBox();
            this.lblFiltroDestino = new System.Windows.Forms.Label();
            this.lblFiltroOrigen = new System.Windows.Forms.Label();
            this.txtBoxFiltroOrigen = new System.Windows.Forms.TextBox();
            this.txtBoxFiltroDestino = new System.Windows.Forms.TextBox();
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
            this.gBoxFiltros.Controls.Add(this.label1);
            this.gBoxFiltros.Controls.Add(this.txtBoxFiltroPrecio);
            this.gBoxFiltros.Controls.Add(this.lblFiltroDestino);
            this.gBoxFiltros.Controls.Add(this.lblFiltroOrigen);
            this.gBoxFiltros.Controls.Add(this.txtBoxFiltroOrigen);
            this.gBoxFiltros.Controls.Add(this.txtBoxFiltroDestino);
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
            this.label2.Location = new System.Drawing.Point(545, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filtro ID";
            // 
            // txtBoxFiltroID
            // 
            this.txtBoxFiltroID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFiltroID.Location = new System.Drawing.Point(613, 56);
            this.txtBoxFiltroID.Name = "txtBoxFiltroID";
            this.txtBoxFiltroID.Size = new System.Drawing.Size(154, 20);
            this.txtBoxFiltroID.TabIndex = 12;
            this.txtBoxFiltroID.TextChanged += new System.EventHandler(this.txtBoxFiltroID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filtro Precio";
            // 
            // txtBoxFiltroPrecio
            // 
            this.txtBoxFiltroPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFiltroPrecio.Location = new System.Drawing.Point(613, 18);
            this.txtBoxFiltroPrecio.Name = "txtBoxFiltroPrecio";
            this.txtBoxFiltroPrecio.Size = new System.Drawing.Size(154, 20);
            this.txtBoxFiltroPrecio.TabIndex = 10;
            this.txtBoxFiltroPrecio.TextChanged += new System.EventHandler(this.txtBoxFiltroPrecio_TextChanged);
            // 
            // lblFiltroDestino
            // 
            this.lblFiltroDestino.AutoSize = true;
            this.lblFiltroDestino.Location = new System.Drawing.Point(19, 59);
            this.lblFiltroDestino.Name = "lblFiltroDestino";
            this.lblFiltroDestino.Size = new System.Drawing.Size(68, 13);
            this.lblFiltroDestino.TabIndex = 9;
            this.lblFiltroDestino.Text = "Filtro Destino";
            // 
            // lblFiltroOrigen
            // 
            this.lblFiltroOrigen.AutoSize = true;
            this.lblFiltroOrigen.Location = new System.Drawing.Point(19, 21);
            this.lblFiltroOrigen.Name = "lblFiltroOrigen";
            this.lblFiltroOrigen.Size = new System.Drawing.Size(63, 13);
            this.lblFiltroOrigen.TabIndex = 8;
            this.lblFiltroOrigen.Text = "Filtro Origen";
            // 
            // txtBoxFiltroOrigen
            // 
            this.txtBoxFiltroOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFiltroOrigen.Location = new System.Drawing.Point(88, 18);
            this.txtBoxFiltroOrigen.MaximumSize = new System.Drawing.Size(425, 20);
            this.txtBoxFiltroOrigen.Name = "txtBoxFiltroOrigen";
            this.txtBoxFiltroOrigen.Size = new System.Drawing.Size(425, 20);
            this.txtBoxFiltroOrigen.TabIndex = 5;
            this.txtBoxFiltroOrigen.TextChanged += new System.EventHandler(this.txtBoxFiltroOrigen_TextChanged);
            // 
            // txtBoxFiltroDestino
            // 
            this.txtBoxFiltroDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFiltroDestino.Location = new System.Drawing.Point(88, 56);
            this.txtBoxFiltroDestino.Name = "txtBoxFiltroDestino";
            this.txtBoxFiltroDestino.Size = new System.Drawing.Size(425, 20);
            this.txtBoxFiltroDestino.TabIndex = 7;
            this.txtBoxFiltroDestino.TextChanged += new System.EventHandler(this.txtBoxFiltroDestino_TextChanged);
            // 
            // frmModificacionesRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.gBoxFiltros);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmModificacionesRecorrido";
            this.Text = "ABM Recorrido";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFiltroPrecio;
        private System.Windows.Forms.Label lblFiltroDestino;
        private System.Windows.Forms.Label lblFiltroOrigen;
        private System.Windows.Forms.TextBox txtBoxFiltroOrigen;
        private System.Windows.Forms.TextBox txtBoxFiltroDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxFiltroID;
    }
}