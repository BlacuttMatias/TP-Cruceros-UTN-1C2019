namespace FrbaCrucero.AbmCrucero
{
    partial class frmAltaCrucero
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cBoxMarca = new System.Windows.Forms.ComboBox();
            this.cBoxModelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.llblSiguiente = new System.Windows.Forms.LinkLabel();
            this.llblAnterior = new System.Windows.Forms.LinkLabel();
            this.superTabla = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCodigoAlerta = new System.Windows.Forms.Label();
            this.lblPiso_ = new System.Windows.Forms.Label();
            this.lblFechaDeAlta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 359);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // cBoxMarca
            // 
            this.cBoxMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxMarca.FormattingEnabled = true;
            this.cBoxMarca.Location = new System.Drawing.Point(462, 14);
            this.cBoxMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxMarca.Name = "cBoxMarca";
            this.cBoxMarca.Size = new System.Drawing.Size(160, 24);
            this.cBoxMarca.TabIndex = 1;
            this.cBoxMarca.SelectedIndexChanged += new System.EventHandler(this.cBoxMarca_SelectedIndexChanged);
            // 
            // cBoxModelo
            // 
            this.cBoxModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxModelo.FormattingEnabled = true;
            this.cBoxModelo.Location = new System.Drawing.Point(462, 47);
            this.cBoxModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxModelo.Name = "cBoxModelo";
            this.cBoxModelo.Size = new System.Drawing.Size(160, 24);
            this.cBoxModelo.TabIndex = 2;
            this.cBoxModelo.SelectedIndexChanged += new System.EventHandler(this.cBoxModelo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Modelo";
            // 
            // lblPiso
            // 
            this.lblPiso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(136, 309);
            this.lblPiso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(16, 17);
            this.lblPiso.TabIndex = 11;
            this.lblPiso.Text = "0";
            this.lblPiso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llblSiguiente
            // 
            this.llblSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llblSiguiente.AutoSize = true;
            this.llblSiguiente.Location = new System.Drawing.Point(176, 309);
            this.llblSiguiente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblSiguiente.Name = "llblSiguiente";
            this.llblSiguiente.Size = new System.Drawing.Size(24, 17);
            this.llblSiguiente.TabIndex = 12;
            this.llblSiguiente.TabStop = true;
            this.llblSiguiente.Text = ">>";
            this.llblSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llblSiguiente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSiguiente_LinkClicked);
            // 
            // llblAnterior
            // 
            this.llblAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llblAnterior.AutoSize = true;
            this.llblAnterior.Location = new System.Drawing.Point(90, 309);
            this.llblAnterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblAnterior.Name = "llblAnterior";
            this.llblAnterior.Size = new System.Drawing.Size(24, 17);
            this.llblAnterior.TabIndex = 13;
            this.llblAnterior.TabStop = true;
            this.llblAnterior.Text = "<<";
            this.llblAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llblAnterior.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAnterior_LinkClicked);
            // 
            // superTabla
            // 
            this.superTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superTabla.ColumnCount = 4;
            this.superTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.superTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.superTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.superTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.superTabla.Location = new System.Drawing.Point(12, 80);
            this.superTabla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.superTabla.Name = "superTabla";
            this.superTabla.RowCount = 1;
            this.superTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.superTabla.Size = new System.Drawing.Size(612, 216);
            this.superTabla.TabIndex = 15;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(524, 368);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(416, 368);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "ej: ABCDEF-12345";
            // 
            // lblCodigoAlerta
            // 
            this.lblCodigoAlerta.AutoSize = true;
            this.lblCodigoAlerta.Location = new System.Drawing.Point(209, 21);
            this.lblCodigoAlerta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoAlerta.Name = "lblCodigoAlerta";
            this.lblCodigoAlerta.Size = new System.Drawing.Size(16, 17);
            this.lblCodigoAlerta.TabIndex = 21;
            this.lblCodigoAlerta.Text = "?";
            // 
            // lblPiso_
            // 
            this.lblPiso_.AutoSize = true;
            this.lblPiso_.Location = new System.Drawing.Point(16, 309);
            this.lblPiso_.Name = "lblPiso_";
            this.lblPiso_.Size = new System.Drawing.Size(35, 17);
            this.lblPiso_.TabIndex = 22;
            this.lblPiso_.Text = "Piso";
            // 
            // lblFechaDeAlta
            // 
            this.lblFechaDeAlta.AutoSize = true;
            this.lblFechaDeAlta.Location = new System.Drawing.Point(9, 359);
            this.lblFechaDeAlta.Name = "lblFechaDeAlta";
            this.lblFechaDeAlta.Size = new System.Drawing.Size(94, 17);
            this.lblFechaDeAlta.TabIndex = 23;
            this.lblFechaDeAlta.Text = "Fecha de alta";
            // 
            // frmAltaCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 409);
            this.Controls.Add(this.lblFechaDeAlta);
            this.Controls.Add(this.lblPiso_);
            this.Controls.Add(this.lblCodigoAlerta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.superTabla);
            this.Controls.Add(this.llblAnterior);
            this.Controls.Add(this.llblSiguiente);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxModelo);
            this.Controls.Add(this.cBoxMarca);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(562, 392);
            this.Name = "frmAltaCrucero";
            this.Text = "frm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cBoxMarca;
        private System.Windows.Forms.ComboBox cBoxModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.LinkLabel llblSiguiente;
        private System.Windows.Forms.LinkLabel llblAnterior;
        private System.Windows.Forms.TableLayoutPanel superTabla;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCodigoAlerta;
        private System.Windows.Forms.Label lblPiso_;
        private System.Windows.Forms.Label lblFechaDeAlta;
    }
}