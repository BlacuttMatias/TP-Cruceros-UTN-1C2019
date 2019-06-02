namespace FrbaCrucero.FormsPrincipales
{
    partial class frmPrincipalCliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mnuSistemaCruceros = new System.Windows.Forms.ToolStripMenuItem();
            this.itmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViaje = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.itmReservar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPagosReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.itmPagarReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistemaCruceros,
            this.mnuViaje,
            this.mnuPagosReserva,
            this.windowsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(80, 24);
            this.windowsMenu.Text = "&Ventanas";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.newWindowToolStripMenuItem.Text = "&Nueva ventana";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.cascadeToolStripMenuItem.Text = "&Cascada";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.closeAllToolStripMenuItem.Text = "C&errar todo";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 533);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // mnuSistemaCruceros
            // 
            this.mnuSistemaCruceros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmSalir});
            this.mnuSistemaCruceros.Name = "mnuSistemaCruceros";
            this.mnuSistemaCruceros.Size = new System.Drawing.Size(134, 24);
            this.mnuSistemaCruceros.Text = "Sistema Cruceros";
            // 
            // itmSalir
            // 
            this.itmSalir.Name = "itmSalir";
            this.itmSalir.Size = new System.Drawing.Size(152, 24);
            this.itmSalir.Text = "Salir";
            this.itmSalir.Click += new System.EventHandler(this.itmSalir_Click);
            // 
            // mnuViaje
            // 
            this.mnuViaje.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmCompra,
            this.itmReservar});
            this.mnuViaje.Name = "mnuViaje";
            this.mnuViaje.Size = new System.Drawing.Size(54, 24);
            this.mnuViaje.Text = "Viaje";
            // 
            // itmCompra
            // 
            this.itmCompra.Name = "itmCompra";
            this.itmCompra.Size = new System.Drawing.Size(173, 24);
            this.itmCompra.Text = "Comprar Viaje";
            this.itmCompra.Click += new System.EventHandler(this.itmCompra_Click);
            // 
            // itmReservar
            // 
            this.itmReservar.Name = "itmReservar";
            this.itmReservar.Size = new System.Drawing.Size(173, 24);
            this.itmReservar.Text = "Reservar Viaje";
            this.itmReservar.Click += new System.EventHandler(this.itmReservar_Click);
            // 
            // mnuPagosReserva
            // 
            this.mnuPagosReserva.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmPagarReserva});
            this.mnuPagosReserva.Name = "mnuPagosReserva";
            this.mnuPagosReserva.Size = new System.Drawing.Size(121, 24);
            this.mnuPagosReserva.Text = "Pagos Reservas";
            // 
            // itmPagarReserva
            // 
            this.itmPagarReserva.Name = "itmPagarReserva";
            this.itmPagarReserva.Size = new System.Drawing.Size(170, 24);
            this.itmPagarReserva.Text = "Pagar Reserva";
            this.itmPagarReserva.Click += new System.EventHandler(this.itmPagarReserva_Click);
            // 
            // frmPrincipalCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipalCliente";
            this.Text = "frmPrincipalCliente";
            this.Load += new System.EventHandler(this.frmPrincipalCliente_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemaCruceros;
        private System.Windows.Forms.ToolStripMenuItem itmSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuViaje;
        private System.Windows.Forms.ToolStripMenuItem itmCompra;
        private System.Windows.Forms.ToolStripMenuItem itmReservar;
        private System.Windows.Forms.ToolStripMenuItem mnuPagosReserva;
        private System.Windows.Forms.ToolStripMenuItem itmPagarReserva;
    }
}



