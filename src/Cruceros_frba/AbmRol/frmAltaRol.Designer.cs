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
            this.label2 = new System.Windows.Forms.Label();
            this.nombreRol = new System.Windows.Forms.TextBox();
            this.listFuncionalidadesNoAgregadas = new System.Windows.Forms.ListBox();
            this.listFuncionalidadesAAgregar = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAgregarFuncionalidades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funcionalidades";
            // 
            // nombreRol
            // 
            this.nombreRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreRol.Location = new System.Drawing.Point(16, 44);
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(349, 20);
            this.nombreRol.TabIndex = 2;
            // 
            // listFuncionalidadesNoAgregadas
            // 
            this.listFuncionalidadesNoAgregadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFuncionalidadesNoAgregadas.FormattingEnabled = true;
            this.listFuncionalidadesNoAgregadas.Location = new System.Drawing.Point(9, 5);
            this.listFuncionalidadesNoAgregadas.Name = "listFuncionalidadesNoAgregadas";
            this.listFuncionalidadesNoAgregadas.Size = new System.Drawing.Size(206, 264);
            this.listFuncionalidadesNoAgregadas.TabIndex = 4;
            this.listFuncionalidadesNoAgregadas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listFuncionalidadesAAgregar
            // 
            this.listFuncionalidadesAAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFuncionalidadesAAgregar.FormattingEnabled = true;
            this.listFuncionalidadesAAgregar.Location = new System.Drawing.Point(3, 5);
            this.listFuncionalidadesAAgregar.Name = "listFuncionalidadesAAgregar";
            this.listFuncionalidadesAAgregar.Size = new System.Drawing.Size(206, 264);
            this.listFuncionalidadesAAgregar.TabIndex = 5;
            this.listFuncionalidadesAAgregar.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 410);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(16, 85);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listFuncionalidadesNoAgregadas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listFuncionalidadesAAgregar);
            this.splitContainer1.Size = new System.Drawing.Size(442, 290);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 7;
            // 
            // btnAgregarFuncionalidades
            // 
            this.btnAgregarFuncionalidades.Location = new System.Drawing.Point(143, 381);
            this.btnAgregarFuncionalidades.Name = "btnAgregarFuncionalidades";
            this.btnAgregarFuncionalidades.Size = new System.Drawing.Size(187, 23);
            this.btnAgregarFuncionalidades.TabIndex = 8;
            this.btnAgregarFuncionalidades.Text = "Confirmar Rol";
            this.btnAgregarFuncionalidades.UseVisualStyleBackColor = true;
            this.btnAgregarFuncionalidades.Click += new System.EventHandler(this.btnAgregarFuncionalidades_Click);
            // 
            // frmAltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 410);
            this.Controls.Add(this.btnAgregarFuncionalidades);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.nombreRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmAltaRol";
            this.Text = "Rol";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreRol;
        private System.Windows.Forms.ListBox listFuncionalidadesNoAgregadas;
        private System.Windows.Forms.ListBox listFuncionalidadesAAgregar;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAgregarFuncionalidades;
    }
}