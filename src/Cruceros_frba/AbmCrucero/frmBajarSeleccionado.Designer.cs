namespace FrbaCrucero.AbmCrucero
{
    partial class frmBajarSeleccionado
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTipoBaja = new System.Windows.Forms.Label();
            this.dtpBaja = new System.Windows.Forms.DateTimePicker();
            this.dtpAlta = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnCancelarTodos = new System.Windows.Forms.Button();
            this.btnReemplazarCrucero = new System.Windows.Forms.Button();
            this.btnPostergarTodos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 11);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblTipoBaja
            // 
            this.lblTipoBaja.AutoSize = true;
            this.lblTipoBaja.Location = new System.Drawing.Point(16, 50);
            this.lblTipoBaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoBaja.Name = "lblTipoBaja";
            this.lblTipoBaja.Size = new System.Drawing.Size(88, 17);
            this.lblTipoBaja.TabIndex = 1;
            this.lblTipoBaja.Text = "Tipo de Baja";
            // 
            // dtpBaja
            // 
            this.dtpBaja.Location = new System.Drawing.Point(423, 11);
            this.dtpBaja.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBaja.Name = "dtpBaja";
            this.dtpBaja.Size = new System.Drawing.Size(265, 22);
            this.dtpBaja.TabIndex = 2;
            this.dtpBaja.ValueChanged += new System.EventHandler(this.dtpBaja_ValueChanged);
            // 
            // dtpAlta
            // 
            this.dtpAlta.Location = new System.Drawing.Point(423, 48);
            this.dtpAlta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAlta.Name = "dtpAlta";
            this.dtpAlta.Size = new System.Drawing.Size(265, 22);
            this.dtpAlta.TabIndex = 3;
            this.dtpAlta.ValueChanged += new System.EventHandler(this.dtpAlta_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 47);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(736, 379);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.MaximumSize = new System.Drawing.Size(100, 28);
            this.btnAceptar.MinimumSize = new System.Drawing.Size(100, 28);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Dar de Baja";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(16, 379);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.MaximumSize = new System.Drawing.Size(100, 28);
            this.btnLimpiar.MinimumSize = new System.Drawing.Size(100, 28);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha Baja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha Alta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 144);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 228);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 124);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(70, 17);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Viajes de:";
            // 
            // btnCancelarTodos
            // 
            this.btnCancelarTodos.Location = new System.Drawing.Point(723, 144);
            this.btnCancelarTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarTodos.Name = "btnCancelarTodos";
            this.btnCancelarTodos.Size = new System.Drawing.Size(135, 50);
            this.btnCancelarTodos.TabIndex = 11;
            this.btnCancelarTodos.Text = "Cancelar Todos y Dar de Baja";
            this.btnCancelarTodos.UseVisualStyleBackColor = true;
            this.btnCancelarTodos.Click += new System.EventHandler(this.btnCancelarTodos_Click);
            // 
            // btnReemplazarCrucero
            // 
            this.btnReemplazarCrucero.Location = new System.Drawing.Point(723, 202);
            this.btnReemplazarCrucero.Margin = new System.Windows.Forms.Padding(4);
            this.btnReemplazarCrucero.Name = "btnReemplazarCrucero";
            this.btnReemplazarCrucero.Size = new System.Drawing.Size(135, 53);
            this.btnReemplazarCrucero.TabIndex = 12;
            this.btnReemplazarCrucero.Text = "Cambiar Crucero y Dar de Baja";
            this.btnReemplazarCrucero.UseVisualStyleBackColor = true;
            this.btnReemplazarCrucero.Click += new System.EventHandler(this.btnReemplazarCrucero_Click);
            // 
            // btnPostergarTodos
            // 
            this.btnPostergarTodos.Location = new System.Drawing.Point(723, 262);
            this.btnPostergarTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPostergarTodos.Name = "btnPostergarTodos";
            this.btnPostergarTodos.Size = new System.Drawing.Size(135, 55);
            this.btnPostergarTodos.TabIndex = 13;
            this.btnPostergarTodos.Text = "Postergar Todos y Dar de Baja";
            this.btnPostergarTodos.UseVisualStyleBackColor = true;
            this.btnPostergarTodos.Click += new System.EventHandler(this.btnPostergarTodos_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 62);
            this.button3.TabIndex = 14;
            this.button3.Text = "Revisar Viajes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmBajarSeleccionado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 422);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPostergarTodos);
            this.Controls.Add(this.btnReemplazarCrucero);
            this.Controls.Add(this.btnCancelarTodos);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtpAlta);
            this.Controls.Add(this.dtpBaja);
            this.Controls.Add(this.lblTipoBaja);
            this.Controls.Add(this.lblCodigo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(406, 250);
            this.Name = "frmBajarSeleccionado";
            this.Text = "Baja de Crucero";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTipoBaja;
        private System.Windows.Forms.DateTimePicker dtpBaja;
        private System.Windows.Forms.DateTimePicker dtpAlta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCancelarTodos;
        private System.Windows.Forms.Button btnReemplazarCrucero;
        private System.Windows.Forms.Button btnPostergarTodos;
        private System.Windows.Forms.Button button3;
    }
}