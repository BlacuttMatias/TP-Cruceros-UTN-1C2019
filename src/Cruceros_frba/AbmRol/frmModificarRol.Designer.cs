namespace FrbaCrucero.AbmRol
{
    partial class frmModificarRol
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
            this.dataGridRoles = new System.Windows.Forms.DataGridView();
            this.rol_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol_habilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRolID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridRoles
            // 
            this.dataGridRoles.AllowUserToDeleteRows = false;
            this.dataGridRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rol_id,
            this.rol_descripcion,
            this.rol_habilitado});
            this.dataGridRoles.Location = new System.Drawing.Point(12, 87);
            this.dataGridRoles.MultiSelect = false;
            this.dataGridRoles.Name = "dataGridRoles";
            this.dataGridRoles.ReadOnly = true;
            this.dataGridRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRoles.Size = new System.Drawing.Size(487, 404);
            this.dataGridRoles.TabIndex = 74;
            this.dataGridRoles.SelectionChanged += new System.EventHandler(this.dataGridRoles_SelectionChanged);
            // 
            // rol_id
            // 
            this.rol_id.HeaderText = "ID";
            this.rol_id.Name = "rol_id";
            this.rol_id.ReadOnly = true;
            // 
            // rol_descripcion
            // 
            this.rol_descripcion.HeaderText = "Descipcion";
            this.rol_descripcion.Name = "rol_descripcion";
            this.rol_descripcion.ReadOnly = true;
            // 
            // rol_habilitado
            // 
            this.rol_habilitado.HeaderText = "Habilitado";
            this.rol_habilitado.Name = "rol_habilitado";
            this.rol_habilitado.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lblRolID);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 69);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(9, 40);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(406, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 13;
            // 
            // lblRolID
            // 
            this.lblRolID.AutoSize = true;
            this.lblRolID.Location = new System.Drawing.Point(6, 16);
            this.lblRolID.Name = "lblRolID";
            this.lblRolID.Size = new System.Drawing.Size(37, 13);
            this.lblRolID.TabIndex = 12;
            this.lblRolID.Text = "Rol ID";
            // 
            // frmModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridRoles);
            this.Name = "frmModificarRol";
            this.Text = "Listado Rol";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRoles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRolID;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_habilitado;
    }
}