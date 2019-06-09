namespace FrbaCrucero.CompraReservaPasaje
{
    partial class frmCliente
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
            this.components = new System.ComponentModel.Container();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.toolTipDni = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTelefono = new System.Windows.Forms.ToolTip(this.components);
            this.listBoxNombres = new System.Windows.Forms.ListBox();
            this.toolTipNombre = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipApellido = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(30, 31);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(31, 17);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(201, 26);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(272, 22);
            this.txtDni.TabIndex = 1;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(201, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(30, 126);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(201, 121);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(272, 22);
            this.txtApellido.TabIndex = 5;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(30, 176);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(201, 171);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(272, 22);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(30, 220);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(47, 17);
            this.lblMail.TabIndex = 8;
            this.lblMail.Text = "E-Mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(201, 215);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(272, 22);
            this.txtMail.TabIndex = 9;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(30, 271);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(201, 266);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(272, 22);
            this.txtDireccion.TabIndex = 11;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(30, 322);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(139, 17);
            this.lblFechaNacimiento.TabIndex = 12;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(273, 317);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaNacimiento.TabIndex = 14;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(593, 426);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(144, 48);
            this.btnConfirmar.TabIndex = 15;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // listBoxNombres
            // 
            this.listBoxNombres.FormattingEnabled = true;
            this.listBoxNombres.ItemHeight = 16;
            this.listBoxNombres.Location = new System.Drawing.Point(512, 26);
            this.listBoxNombres.Name = "listBoxNombres";
            this.listBoxNombres.Size = new System.Drawing.Size(258, 52);
            this.listBoxNombres.TabIndex = 16;
            this.listBoxNombres.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxNombres_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(479, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(479, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(479, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(479, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 36);
            this.label4.TabIndex = 20;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(479, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 36);
            this.label5.TabIndex = 21;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(479, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 36);
            this.label6.TabIndex = 22;
            this.label6.Text = "*";
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamposObligatorios.ForeColor = System.Drawing.Color.Red;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(28, 467);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(217, 25);
            this.lblCamposObligatorios.TabIndex = 23;
            this.lblCamposObligatorios.Text = "Campos obligatorios (*)";
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Location = new System.Drawing.Point(597, 339);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(139, 52);
            this.btnDeshacer.TabIndex = 24;
            this.btnDeshacer.Text = "Deshacer";
            this.btnDeshacer.UseVisualStyleBackColor = true;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.btnDeshacer);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxNombres);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Name = "frmCliente";
            this.Text = "Ingreso datos Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frmCliente_MouseDoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ToolTip toolTipDni;
        private System.Windows.Forms.ToolTip toolTipTelefono;
        private System.Windows.Forms.ListBox listBoxNombres;
        private System.Windows.Forms.ToolTip toolTipNombre;
        private System.Windows.Forms.ToolTip toolTipApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Button btnDeshacer;
    }
}