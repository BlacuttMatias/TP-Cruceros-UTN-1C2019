namespace FrbaCrucero.PagoReserva
{
    partial class frmPagoReserva
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
            this.lblReserva = new System.Windows.Forms.Label();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.toolTipCodigoReserva = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Location = new System.Drawing.Point(132, 55);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(256, 17);
            this.lblReserva.TabIndex = 0;
            this.lblReserva.Text = "Ingrese el código de la reserva a pagar";
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(133, 102);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(255, 22);
            this.txtReserva.TabIndex = 1;
            this.txtReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReserva_KeyPress);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(175, 194);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(171, 60);
            this.btnPagar.TabIndex = 2;
            this.btnPagar.Text = "Pagar reserva";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // frmPagoReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 318);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtReserva);
            this.Controls.Add(this.lblReserva);
            this.Name = "frmPagoReserva";
            this.Text = "Pago de reserva";
            this.Load += new System.EventHandler(this.frmPagoReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.ToolTip toolTipCodigoReserva;
    }
}