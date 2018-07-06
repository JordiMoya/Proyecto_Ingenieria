namespace Capa_Presentacion
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlLaboralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasLaboralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsusarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosDeRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesAUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteCompaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePagoPorEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.controlLaboralToolStripMenuItem,
            this.facturaciónToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoríaToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.empleadoToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registroToolStripMenuItem.Text = "Registrar";
            // 
            // categoríaToolStripMenuItem
            // 
            this.categoríaToolStripMenuItem.Name = "categoríaToolStripMenuItem";
            this.categoríaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.categoríaToolStripMenuItem.Text = "Categoría";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // controlLaboralToolStripMenuItem
            // 
            this.controlLaboralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horasLaboralesToolStripMenuItem,
            this.pagosEmpleadosToolStripMenuItem});
            this.controlLaboralToolStripMenuItem.Name = "controlLaboralToolStripMenuItem";
            this.controlLaboralToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.controlLaboralToolStripMenuItem.Text = "Control laboral";
            // 
            // horasLaboralesToolStripMenuItem
            // 
            this.horasLaboralesToolStripMenuItem.Name = "horasLaboralesToolStripMenuItem";
            this.horasLaboralesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.horasLaboralesToolStripMenuItem.Text = "Horas laborales";
            // 
            // pagosEmpleadosToolStripMenuItem
            // 
            this.pagosEmpleadosToolStripMenuItem.Name = "pagosEmpleadosToolStripMenuItem";
            this.pagosEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pagosEmpleadosToolStripMenuItem.Text = "Pagos empleados";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cobrosToolStripMenuItem,
            this.ingresosToolStripMenuItem});
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // cobrosToolStripMenuItem
            // 
            this.cobrosToolStripMenuItem.Name = "cobrosToolStripMenuItem";
            this.cobrosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cobrosToolStripMenuItem.Text = "Cobros";
            this.cobrosToolStripMenuItem.Click += new System.EventHandler(this.cobrosToolStripMenuItem_Click);
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsusarioToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.permisosDeRolesToolStripMenuItem,
            this.rolesAUsuariosToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // nuevoUsusarioToolStripMenuItem
            // 
            this.nuevoUsusarioToolStripMenuItem.Name = "nuevoUsusarioToolStripMenuItem";
            this.nuevoUsusarioToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.nuevoUsusarioToolStripMenuItem.Text = "Usuarios";
            this.nuevoUsusarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsusarioToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // permisosDeRolesToolStripMenuItem
            // 
            this.permisosDeRolesToolStripMenuItem.Name = "permisosDeRolesToolStripMenuItem";
            this.permisosDeRolesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.permisosDeRolesToolStripMenuItem.Text = "Roles a vistas";
            // 
            // rolesAUsuariosToolStripMenuItem
            // 
            this.rolesAUsuariosToolStripMenuItem.Name = "rolesAUsuariosToolStripMenuItem";
            this.rolesAUsuariosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.rolesAUsuariosToolStripMenuItem.Text = "Roles a usuarios";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeIngresosToolStripMenuItem,
            this.reporteCompaToolStripMenuItem,
            this.reportePagoPorEmpleadoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeIngresosToolStripMenuItem
            // 
            this.reporteDeIngresosToolStripMenuItem.Name = "reporteDeIngresosToolStripMenuItem";
            this.reporteDeIngresosToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.reporteDeIngresosToolStripMenuItem.Text = "Reporte de ingresos";
            // 
            // reporteCompaToolStripMenuItem
            // 
            this.reporteCompaToolStripMenuItem.Name = "reporteCompaToolStripMenuItem";
            this.reporteCompaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.reporteCompaToolStripMenuItem.Text = "Reporte ingresos y cobros";
            // 
            // reportePagoPorEmpleadoToolStripMenuItem
            // 
            this.reportePagoPorEmpleadoToolStripMenuItem.Name = "reportePagoPorEmpleadoToolStripMenuItem";
            this.reportePagoPorEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.reportePagoPorEmpleadoToolStripMenuItem.Text = "Reporte pago por empleado";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Capa_Presentacion.Properties.Resources.cuadradoX1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlLaboralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasLaboralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsusarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosDeRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesAUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteCompaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePagoPorEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}