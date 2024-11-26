namespace SistemaEmpleados
{
    partial class frmBusquedaEmpleado
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
            this.grpListadoEmpleados = new System.Windows.Forms.GroupBox();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpListadoEmpleados.SuspendLayout();
            this.grpInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListadoEmpleados
            // 
            this.grpListadoEmpleados.Controls.Add(this.txtCodigoEmpleado);
            this.grpListadoEmpleados.Controls.Add(this.grpInformacion);
            this.grpListadoEmpleados.Controls.Add(this.lblNombres);
            this.grpListadoEmpleados.Controls.Add(this.btnBuscar);
            this.grpListadoEmpleados.Location = new System.Drawing.Point(12, 12);
            this.grpListadoEmpleados.Name = "grpListadoEmpleados";
            this.grpListadoEmpleados.Size = new System.Drawing.Size(327, 429);
            this.grpListadoEmpleados.TabIndex = 3;
            this.grpListadoEmpleados.TabStop = false;
            this.grpListadoEmpleados.Text = "Busqueda de empleado";
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(132, 42);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEmpleado.TabIndex = 9;
            this.txtCodigoEmpleado.TextChanged += new System.EventHandler(this.txtCodigoEmpleado_TextChanged);
            // 
            // grpInformacion
            // 
            this.grpInformacion.Controls.Add(this.label5);
            this.grpInformacion.Controls.Add(this.lblNombre);
            this.grpInformacion.Controls.Add(this.label4);
            this.grpInformacion.Controls.Add(this.lblSueldo);
            this.grpInformacion.Controls.Add(this.label2);
            this.grpInformacion.Controls.Add(this.lblCodigo);
            this.grpInformacion.Controls.Add(this.label1);
            this.grpInformacion.Controls.Add(this.lblCategoria);
            this.grpInformacion.Location = new System.Drawing.Point(9, 149);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(223, 183);
            this.grpInformacion.TabIndex = 8;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Informacion del empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre:";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(71, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoria:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(71, 130);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(100, 23);
            this.lblSueldo.TabIndex = 5;
            this.lblSueldo.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(71, 60);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(100, 23);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sueldo:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(81, 95);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(100, 23);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = " ";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(6, 46);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(120, 16);
            this.lblNombres.TabIndex = 6;
            this.lblNombres.Text = "Codigo Empleado:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(9, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(223, 37);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmBusquedaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 558);
            this.Controls.Add(this.grpListadoEmpleados);
            this.Name = "frmBusquedaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de un empleado";
            this.grpListadoEmpleados.ResumeLayout(false);
            this.grpListadoEmpleados.PerformLayout();
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListadoEmpleados;
        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombre;
    }
}