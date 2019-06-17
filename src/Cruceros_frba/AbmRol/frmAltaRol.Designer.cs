namespace FrbaCrucero.AbmRol
{
    partial class frmAltaRol
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFuncionalidades = new System.Windows.Forms.Label();
            this.nombreRol = new System.Windows.Forms.TextBox();
            this.listFuncionalidadesNoAgregadas = new System.Windows.Forms.ListBox();
            this.listFuncionalidadesAAgregar = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAgregarFuncionalidades = new System.Windows.Forms.Button();
            this.lblFuncExistentes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 16);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFuncionalidades
            // 
            this.lblFuncionalidades.AutoSize = true;
            this.lblFuncionalidades.Location = new System.Drawing.Point(18, 99);
            this.lblFuncionalidades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncionalidades.Name = "lblFuncionalidades";
            this.lblFuncionalidades.Size = new System.Drawing.Size(115, 17);
            this.lblFuncionalidades.TabIndex = 2;
            this.lblFuncionalidades.Text = "Funcionalidades:";
            // 
            // nombreRol
            // 
            this.nombreRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreRol.Location = new System.Drawing.Point(21, 54);
            this.nombreRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(464, 22);
            this.nombreRol.TabIndex = 2;
            // 
            // listFuncionalidadesNoAgregadas
            // 
            this.listFuncionalidadesNoAgregadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFuncionalidadesNoAgregadas.FormattingEnabled = true;
            this.listFuncionalidadesNoAgregadas.ItemHeight = 16;
            this.listFuncionalidadesNoAgregadas.Location = new System.Drawing.Point(12, 6);
            this.listFuncionalidadesNoAgregadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listFuncionalidadesNoAgregadas.Name = "listFuncionalidadesNoAgregadas";
            this.listFuncionalidadesNoAgregadas.Size = new System.Drawing.Size(272, 340);
            this.listFuncionalidadesNoAgregadas.TabIndex = 4;
            this.listFuncionalidadesNoAgregadas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listFuncionalidadesAAgregar
            // 
            this.listFuncionalidadesAAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFuncionalidadesAAgregar.FormattingEnabled = true;
            this.listFuncionalidadesAAgregar.ItemHeight = 16;
            this.listFuncionalidadesAAgregar.Location = new System.Drawing.Point(4, 6);
            this.listFuncionalidadesAAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listFuncionalidadesAAgregar.Name = "listFuncionalidadesAAgregar";
            this.listFuncionalidadesAAgregar.Size = new System.Drawing.Size(274, 340);
            this.listFuncionalidadesAAgregar.TabIndex = 5;
            this.listFuncionalidadesAAgregar.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 563);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(21, 159);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listFuncionalidadesNoAgregadas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listFuncionalidadesAAgregar);
            this.splitContainer1.Size = new System.Drawing.Size(589, 355);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 7;
            // 
            // btnAgregarFuncionalidades
            // 
            this.btnAgregarFuncionalidades.Location = new System.Drawing.Point(191, 522);
            this.btnAgregarFuncionalidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarFuncionalidades.Name = "btnAgregarFuncionalidades";
            this.btnAgregarFuncionalidades.Size = new System.Drawing.Size(249, 28);
            this.btnAgregarFuncionalidades.TabIndex = 8;
            this.btnAgregarFuncionalidades.Text = "Confirmar Rol";
            this.btnAgregarFuncionalidades.UseVisualStyleBackColor = true;
            this.btnAgregarFuncionalidades.Click += new System.EventHandler(this.btnAgregarFuncionalidades_Click);
            // 
            // lblFuncExistentes
            // 
            this.lblFuncExistentes.AutoSize = true;
            this.lblFuncExistentes.Location = new System.Drawing.Point(28, 135);
            this.lblFuncExistentes.Name = "lblFuncExistentes";
            this.lblFuncExistentes.Size = new System.Drawing.Size(178, 17);
            this.lblFuncExistentes.TabIndex = 9;
            this.lblFuncExistentes.Text = "Funcionalidades existentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Funcionalidades que posee el Rol";
            // 
            // frmAltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 563);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFuncExistentes);
            this.Controls.Add(this.btnAgregarFuncionalidades);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.nombreRol);
            this.Controls.Add(this.lblFuncionalidades);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAltaRol";
            this.Text = "Alta Rol";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFuncionalidades;
        private System.Windows.Forms.TextBox nombreRol;
        private System.Windows.Forms.ListBox listFuncionalidadesNoAgregadas;
        private System.Windows.Forms.ListBox listFuncionalidadesAAgregar;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAgregarFuncionalidades;
        private System.Windows.Forms.Label lblFuncExistentes;
        private System.Windows.Forms.Label label1;
    }
}