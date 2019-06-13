namespace FrbaCrucero.FormsPrincipales
{
    partial class frmPrincipalAdmin
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
            this.mnuSistemaCruceros = new System.Windows.Forms.ToolStripMenuItem();
            this.itmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuABMs = new System.Windows.Forms.ToolStripMenuItem();
            this.itmRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.itmPuertos = new System.Windows.Forms.ToolStripMenuItem();
            this.itmRecorridos = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCruceros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViaje = new System.Windows.Forms.ToolStripMenuItem();
            this.itmGenerarViaje = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.itmReservar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPagosReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.itmPagarReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosEstadísticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itmListadosEstadísticos = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistemaCruceros,
            this.mnuABMs,
            this.mnuViaje,
            this.mnuPagosReserva,
            this.listadosEstadísticosToolStripMenuItem,
            this.windowsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
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
            this.itmSalir.Size = new System.Drawing.Size(107, 24);
            this.itmSalir.Text = "Salir";
            this.itmSalir.Click += new System.EventHandler(this.itmSalir_Click);
            // 
            // mnuABMs
            // 
            this.mnuABMs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmRoles,
            this.itmPuertos,
            this.itmRecorridos,
            this.itmCruceros});
            this.mnuABMs.Name = "mnuABMs";
            this.mnuABMs.Size = new System.Drawing.Size(59, 24);
            this.mnuABMs.Text = "ABMs";
            // 
            // itmRoles
            // 
            this.itmRoles.Name = "itmRoles";
            this.itmRoles.Size = new System.Drawing.Size(149, 24);
            this.itmRoles.Text = "Roles";
            this.itmRoles.Click += new System.EventHandler(this.itmRoles_Click);
            // 
            // itmPuertos
            // 
            this.itmPuertos.Name = "itmPuertos";
            this.itmPuertos.Size = new System.Drawing.Size(149, 24);
            this.itmPuertos.Text = "Puertos";
            this.itmPuertos.Click += new System.EventHandler(this.itmPuertos_Click);
            // 
            // itmRecorridos
            // 
            this.itmRecorridos.Name = "itmRecorridos";
            this.itmRecorridos.Size = new System.Drawing.Size(149, 24);
            this.itmRecorridos.Text = "Recorridos";
            this.itmRecorridos.Click += new System.EventHandler(this.itmRecorridos_Click);
            // 
            // itmCruceros
            // 
            this.itmCruceros.Name = "itmCruceros";
            this.itmCruceros.Size = new System.Drawing.Size(149, 24);
            this.itmCruceros.Text = "Cruceros";
            // 
            // mnuViaje
            // 
            this.mnuViaje.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmGenerarViaje,
            this.itmCompra,
            this.itmReservar});
            this.mnuViaje.Name = "mnuViaje";
            this.mnuViaje.Size = new System.Drawing.Size(54, 24);
            this.mnuViaje.Text = "Viaje";
            // 
            // itmGenerarViaje
            // 
            this.itmGenerarViaje.Name = "itmGenerarViaje";
            this.itmGenerarViaje.Size = new System.Drawing.Size(231, 24);
            this.itmGenerarViaje.Text = "Generar un nuevo Viaje";
            this.itmGenerarViaje.Click += new System.EventHandler(this.itmGenerarViaje_Click);
            // 
            // itmCompra
            // 
            this.itmCompra.Name = "itmCompra";
            this.itmCompra.Size = new System.Drawing.Size(231, 24);
            this.itmCompra.Text = "Comprar Viaje";
            this.itmCompra.Click += new System.EventHandler(this.itmCompra_Click);
            // 
            // itmReservar
            // 
            this.itmReservar.Name = "itmReservar";
            this.itmReservar.Size = new System.Drawing.Size(231, 24);
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
            // listadosEstadísticosToolStripMenuItem
            // 
            this.listadosEstadísticosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmListadosEstadísticos});
            this.listadosEstadísticosToolStripMenuItem.Name = "listadosEstadísticosToolStripMenuItem";
            this.listadosEstadísticosToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.listadosEstadísticosToolStripMenuItem.Text = "Listados Estadísticos";
            // 
            // itmListadosEstadísticos
            // 
            this.itmListadosEstadísticos.Name = "itmListadosEstadísticos";
            this.itmListadosEstadísticos.Size = new System.Drawing.Size(238, 24);
            this.itmListadosEstadísticos.Text = "Ver Listados Estadísticos";
            this.itmListadosEstadísticos.Click += new System.EventHandler(this.itmListadosEstadísticos_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
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
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.arrangeIconsToolStripMenuItem.Text = "&Organizar iconos";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
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
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(843, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // frmPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipalAdmin";
            this.Text = "Cruceros FRBA ";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
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
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemaCruceros;
        private System.Windows.Forms.ToolStripMenuItem itmSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuABMs;
        private System.Windows.Forms.ToolStripMenuItem itmRoles;
        private System.Windows.Forms.ToolStripMenuItem itmPuertos;
        private System.Windows.Forms.ToolStripMenuItem itmRecorridos;
        private System.Windows.Forms.ToolStripMenuItem itmCruceros;
        private System.Windows.Forms.ToolStripMenuItem mnuViaje;
        private System.Windows.Forms.ToolStripMenuItem itmGenerarViaje;
        private System.Windows.Forms.ToolStripMenuItem itmCompra;
        private System.Windows.Forms.ToolStripMenuItem itmReservar;
        private System.Windows.Forms.ToolStripMenuItem mnuPagosReserva;
        private System.Windows.Forms.ToolStripMenuItem itmPagarReserva;
        private System.Windows.Forms.ToolStripMenuItem listadosEstadísticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itmListadosEstadísticos;
    }
}



