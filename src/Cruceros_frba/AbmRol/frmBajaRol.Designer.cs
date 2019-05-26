namespace FrbaCrucero.AbmRol
{
    partial class frmBajaRol
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
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.dataGridRoles = new System.Windows.Forms.DataGridView();
            this.rolCodigo = new System.Windows.Forms.TextBox();
            this.rolDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rol_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol_esta_habilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarRol.Location = new System.Drawing.Point(379, 31);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarRol.TabIndex = 0;
            this.btnEliminarRol.Text = "Eliminar Rol";
            this.btnEliminarRol.UseVisualStyleBackColor = true;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // dataGridRoles
            // 
            this.dataGridRoles.AllowUserToAddRows = false;
            this.dataGridRoles.AllowUserToDeleteRows = false;
            this.dataGridRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoles.Location = new System.Drawing.Point(12, 60);
            this.dataGridRoles.MultiSelect = false;
            this.dataGridRoles.Name = "dataGridRoles";
            this.dataGridRoles.ReadOnly = true;
            this.dataGridRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRoles.Size = new System.Drawing.Size(443, 270);
            this.dataGridRoles.TabIndex = 81;
            this.dataGridRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRoles_CellClick);
            // 
            // rolCodigo
            // 
            this.rolCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rolCodigo.Location = new System.Drawing.Point(26, 31);
            this.rolCodigo.Name = "rolCodigo";
            this.rolCodigo.Size = new System.Drawing.Size(149, 20);
            this.rolCodigo.TabIndex = 2;
            // 
            // rolDescripcion
            // 
            this.rolDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rolDescripcion.Location = new System.Drawing.Point(205, 31);
            this.rolDescripcion.MaximumSize = new System.Drawing.Size(156, 20);
            this.rolDescripcion.MinimumSize = new System.Drawing.Size(156, 20);
            this.rolDescripcion.Name = "rolDescripcion";
            this.rolDescripcion.Size = new System.Drawing.Size(156, 20);
            this.rolDescripcion.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion";
            // 
            // rol_codigo
            // 
            this.rol_codigo.HeaderText = "Codigo";
            this.rol_codigo.Name = "rol_codigo";
            // 
            // rol_descripcion
            // 
            this.rol_descripcion.HeaderText = "Descripcion";
            this.rol_descripcion.Name = "rol_descripcion";
            // 
            // rol_esta_habilitado
            // 
            this.rol_esta_habilitado.HeaderText = "Habilitado";
            this.rol_esta_habilitado.Name = "rol_esta_habilitado";
            // 
            // frmBajaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rolDescripcion);
            this.Controls.Add(this.rolCodigo);
            this.Controls.Add(this.dataGridRoles);
            this.Controls.Add(this.btnEliminarRol);
            this.MaximizeBox = false;
            this.Name = "frmBajaRol";
            this.Text = "frmEliminarRol";
            this.Load += new System.EventHandler(this.frmBajaRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.DataGridView dataGridRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_esta_habilitado;
        private System.Windows.Forms.TextBox rolCodigo;
        private System.Windows.Forms.TextBox rolDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}