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
            this.lblRolID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridRoles
            // 
            this.dataGridRoles.AllowUserToAddRows = false;
            this.dataGridRoles.AllowUserToDeleteRows = false;
            this.dataGridRoles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoles.Location = new System.Drawing.Point(5, 36);
            this.dataGridRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridRoles.MaximumSize = new System.Drawing.Size(649, 497);
            this.dataGridRoles.MinimumSize = new System.Drawing.Size(649, 497);
            this.dataGridRoles.MultiSelect = false;
            this.dataGridRoles.Name = "dataGridRoles";
            this.dataGridRoles.ReadOnly = true;
            this.dataGridRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRoles.Size = new System.Drawing.Size(649, 497);
            this.dataGridRoles.TabIndex = 81;
            this.dataGridRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRoles_CellContentClick);
            // 
            // lblRolID
            // 
            this.lblRolID.AutoSize = true;
            this.lblRolID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRolID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolID.Location = new System.Drawing.Point(4, 0);
            this.lblRolID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRolID.Name = "lblRolID";
            this.lblRolID.Size = new System.Drawing.Size(651, 32);
            this.lblRolID.TabIndex = 12;
            this.lblRolID.Text = "Seleccione un Rol";
            this.lblRolID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridRoles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRolID, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.060606F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.93939F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 537);
            this.tableLayoutPanel1.TabIndex = 82;
            // 
            // frmModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmModificarRol";
            this.Text = "Listado Roles";
            this.Activated += new System.EventHandler(this.frmModificarRol_Load);
            this.Load += new System.EventHandler(this.frmModificarRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRoles;
        private System.Windows.Forms.Label lblRolID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_habilitado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn rol_codigo;
    }
}