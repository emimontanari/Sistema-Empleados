namespace SistemaEmpleados
{
    partial class SistemaDeEmpleados
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaAutomaticaDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCantidadProducidaDeUnEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTotalProducidoEnCadaMaquinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.produccionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1834, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.cargaAutomaticaDeDatosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(117, 38);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(438, 44);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // cargaAutomaticaDeDatosToolStripMenuItem
            // 
            this.cargaAutomaticaDeDatosToolStripMenuItem.Name = "cargaAutomaticaDeDatosToolStripMenuItem";
            this.cargaAutomaticaDeDatosToolStripMenuItem.Size = new System.Drawing.Size(438, 44);
            this.cargaAutomaticaDeDatosToolStripMenuItem.Text = "Carga Automatica de Datos";
            this.cargaAutomaticaDeDatosToolStripMenuItem.Click += new System.EventHandler(this.cargaAutomaticaDeDatosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(435, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(438, 44);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // produccionToolStripMenuItem
            // 
            this.produccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCantidadProducidaDeUnEmpleadoToolStripMenuItem,
            this.listarTotalProducidoEnCadaMaquinaToolStripMenuItem});
            this.produccionToolStripMenuItem.Name = "produccionToolStripMenuItem";
            this.produccionToolStripMenuItem.Size = new System.Drawing.Size(153, 38);
            this.produccionToolStripMenuItem.Text = "Produccion";
            // 
            // consultarCantidadProducidaDeUnEmpleadoToolStripMenuItem
            // 
            this.consultarCantidadProducidaDeUnEmpleadoToolStripMenuItem.Name = "consultarCantidadProducidaDeUnEmpleadoToolStripMenuItem";
            this.consultarCantidadProducidaDeUnEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(658, 44);
            this.consultarCantidadProducidaDeUnEmpleadoToolStripMenuItem.Text = "Consultar cantidad producida de un empleado...";
            this.consultarCantidadProducidaDeUnEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.consultarCantidadProducidaDeUnEmpleadoToolStripMenuItem_Click);
            // 
            // listarTotalProducidoEnCadaMaquinaToolStripMenuItem
            // 
            this.listarTotalProducidoEnCadaMaquinaToolStripMenuItem.Name = "listarTotalProducidoEnCadaMaquinaToolStripMenuItem";
            this.listarTotalProducidoEnCadaMaquinaToolStripMenuItem.Size = new System.Drawing.Size(658, 44);
            this.listarTotalProducidoEnCadaMaquinaToolStripMenuItem.Text = "Listar total producido por cada empleado...";
            this.listarTotalProducidoEnCadaMaquinaToolStripMenuItem.Click += new System.EventHandler(this.listarTotalProducidoEnCadaMaquinaToolStripMenuItem_Click);
            // 
            // SistemaDeEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 932);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SistemaDeEmpleados";
            this.Text = "Sistema de empleados y maquinarias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaAutomaticaDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCantidadProducidaDeUnEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTotalProducidoEnCadaMaquinaToolStripMenuItem;
    }
}

