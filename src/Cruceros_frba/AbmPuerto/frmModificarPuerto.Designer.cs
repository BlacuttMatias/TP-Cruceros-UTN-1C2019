namespace FrbaCrucero.AbmPuerto
{
    partial class frmModificarPuerto
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
            this.dataGridPuertos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuertos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPuertos
            // 
            this.dataGridPuertos.AllowUserToAddRows = false;
            this.dataGridPuertos.AllowUserToDeleteRows = false;
            this.dataGridPuertos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPuertos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPuertos.Location = new System.Drawing.Point(12, 34);
            this.dataGridPuertos.MaximumSize = new System.Drawing.Size(487, 404);
            this.dataGridPuertos.MinimumSize = new System.Drawing.Size(487, 404);
            this.dataGridPuertos.MultiSelect = false;
            this.dataGridPuertos.Name = "dataGridPuertos";
            this.dataGridPuertos.ReadOnly = true;
            this.dataGridPuertos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPuertos.Size = new System.Drawing.Size(487, 404);
            this.dataGridPuertos.TabIndex = 81;
            this.dataGridPuertos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPuertos_CellClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(154, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(190, 25);
            this.lblTitulo.TabIndex = 82;
            this.lblTitulo.Text = "Seleccione un Puerto";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmModificarPuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridPuertos);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(525, 488);
            this.MinimumSize = new System.Drawing.Size(525, 488);
            this.Name = "frmModificarPuerto";
            this.Text = "Listado Puerto Bajas y Modificaciones";
            this.Activated += new System.EventHandler(this.frmModificarPuerto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuertos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPuertos;
        private System.Windows.Forms.Label lblTitulo;
    }
}