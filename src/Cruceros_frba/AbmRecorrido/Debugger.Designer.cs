

namespace FrbaCrucero.AbmRecorrido
{
    partial class Debugger
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
            this.txtDebugger = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTexto = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridDestino = new System.Windows.Forms.DataGridView();
            this.dataGridOrigen = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridExisteTramo = new System.Windows.Forms.DataGridView();
            this.dataGridCodigoTramo = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridExtra = new System.Windows.Forms.DataGridView();
            this.dataGridTramoXReco = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabTexto.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrigen)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExisteTramo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCodigoTramo)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramoXReco)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDebugger
            // 
            this.txtDebugger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDebugger.Location = new System.Drawing.Point(3, 3);
            this.txtDebugger.Multiline = true;
            this.txtDebugger.Name = "txtDebugger";
            this.txtDebugger.Size = new System.Drawing.Size(786, 418);
            this.txtDebugger.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTexto);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 1;
            this.tabControl.Tag = "";
            // 
            // tabTexto
            // 
            this.tabTexto.Controls.Add(this.txtDebugger);
            this.tabTexto.Location = new System.Drawing.Point(4, 22);
            this.tabTexto.Name = "tabTexto";
            this.tabTexto.Padding = new System.Windows.Forms.Padding(3);
            this.tabTexto.Size = new System.Drawing.Size(792, 424);
            this.tabTexto.TabIndex = 0;
            this.tabTexto.Text = "Texto";
            this.tabTexto.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tablas SP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridDestino, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridOrigen, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridDestino
            // 
            this.dataGridDestino.AllowUserToAddRows = false;
            this.dataGridDestino.AllowUserToDeleteRows = false;
            this.dataGridDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDestino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDestino.Location = new System.Drawing.Point(3, 212);
            this.dataGridDestino.Name = "dataGridDestino";
            this.dataGridDestino.ReadOnly = true;
            this.dataGridDestino.Size = new System.Drawing.Size(780, 203);
            this.dataGridDestino.TabIndex = 0;
            // 
            // dataGridOrigen
            // 
            this.dataGridOrigen.AllowUserToAddRows = false;
            this.dataGridOrigen.AllowUserToDeleteRows = false;
            this.dataGridOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrigen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridOrigen.Location = new System.Drawing.Point(3, 3);
            this.dataGridOrigen.Name = "dataGridOrigen";
            this.dataGridOrigen.ReadOnly = true;
            this.dataGridOrigen.Size = new System.Drawing.Size(780, 203);
            this.dataGridOrigen.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tablas Select";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridExisteTramo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridCodigoTramo, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridExisteTramo
            // 
            this.dataGridExisteTramo.AllowUserToAddRows = false;
            this.dataGridExisteTramo.AllowUserToDeleteRows = false;
            this.dataGridExisteTramo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExisteTramo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridExisteTramo.Location = new System.Drawing.Point(3, 3);
            this.dataGridExisteTramo.Name = "dataGridExisteTramo";
            this.dataGridExisteTramo.ReadOnly = true;
            this.dataGridExisteTramo.Size = new System.Drawing.Size(780, 203);
            this.dataGridExisteTramo.TabIndex = 0;
            // 
            // dataGridCodigoTramo
            // 
            this.dataGridCodigoTramo.AllowUserToAddRows = false;
            this.dataGridCodigoTramo.AllowUserToDeleteRows = false;
            this.dataGridCodigoTramo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCodigoTramo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCodigoTramo.Location = new System.Drawing.Point(3, 212);
            this.dataGridCodigoTramo.Name = "dataGridCodigoTramo";
            this.dataGridCodigoTramo.ReadOnly = true;
            this.dataGridCodigoTramo.Size = new System.Drawing.Size(780, 203);
            this.dataGridCodigoTramo.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tablas Extra";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridExtra, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dataGridTramoXReco, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dataGridExtra
            // 
            this.dataGridExtra.AllowUserToAddRows = false;
            this.dataGridExtra.AllowUserToDeleteRows = false;
            this.dataGridExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridExtra.Location = new System.Drawing.Point(3, 212);
            this.dataGridExtra.Name = "dataGridExtra";
            this.dataGridExtra.ReadOnly = true;
            this.dataGridExtra.Size = new System.Drawing.Size(780, 203);
            this.dataGridExtra.TabIndex = 0;
            // 
            // dataGridTramoXReco
            // 
            this.dataGridTramoXReco.AllowUserToAddRows = false;
            this.dataGridTramoXReco.AllowUserToDeleteRows = false;
            this.dataGridTramoXReco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTramoXReco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTramoXReco.Location = new System.Drawing.Point(3, 3);
            this.dataGridTramoXReco.Name = "dataGridTramoXReco";
            this.dataGridTramoXReco.ReadOnly = true;
            this.dataGridTramoXReco.Size = new System.Drawing.Size(780, 203);
            this.dataGridTramoXReco.TabIndex = 1;
            // 
            // Debugger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Debugger";
            this.Text = "Debugger";
            this.tabControl.ResumeLayout(false);
            this.tabTexto.ResumeLayout(false);
            this.tabTexto.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrigen)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExisteTramo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCodigoTramo)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramoXReco)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TextBox txtDebugger;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTexto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridDestino;
        private System.Windows.Forms.DataGridView dataGridOrigen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridExisteTramo;
        private System.Windows.Forms.DataGridView dataGridCodigoTramo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridExtra;
        private System.Windows.Forms.DataGridView dataGridTramoXReco;
    }
}