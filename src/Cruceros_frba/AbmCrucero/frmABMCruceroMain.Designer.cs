namespace FrbaCrucero.AbmCrucero
{
    partial class frmABMCruceroMain
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
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBajas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnBajas, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnModificacion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAlta, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(251, 212);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnModificacion
            // 
            this.btnModificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificacion.Location = new System.Drawing.Point(3, 73);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(245, 64);
            this.btnModificacion.TabIndex = 1;
            this.btnModificacion.Text = "Modificaciones";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlta.Location = new System.Drawing.Point(3, 3);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(245, 64);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "Altas";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBajas
            // 
            this.btnBajas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBajas.Location = new System.Drawing.Point(3, 143);
            this.btnBajas.Name = "btnBajas";
            this.btnBajas.Size = new System.Drawing.Size(245, 66);
            this.btnBajas.TabIndex = 2;
            this.btnBajas.Text = "Bajas";
            this.btnBajas.UseVisualStyleBackColor = true;
            this.btnBajas.Click += new System.EventHandler(this.btnBajas_Click);
            // 
            // frmABMCruceroMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 212);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmABMCruceroMain";
            this.Text = "ABM Crucero";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBajas;
    }
}