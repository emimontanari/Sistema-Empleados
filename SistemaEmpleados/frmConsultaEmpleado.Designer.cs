namespace SistemaEmpleados
{
    partial class frmConsultaEmpleado
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
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grpListadoEmpleados.SuspendLayout();
            this.grpInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListadoEmpleados
            // 
            this.grpListadoEmpleados.Controls.Add(this.grpInformacion);
            this.grpListadoEmpleados.Controls.Add(this.cmbEmpleados);
            this.grpListadoEmpleados.Controls.Add(this.lblNombres);
            this.grpListadoEmpleados.Controls.Add(this.btnConsultar);
            this.grpListadoEmpleados.Location = new System.Drawing.Point(12, 12);
            this.grpListadoEmpleados.Name = "grpListadoEmpleados";
            this.grpListadoEmpleados.Size = new System.Drawing.Size(327, 429);
            this.grpListadoEmpleados.TabIndex = 2;
            this.grpListadoEmpleados.TabStop = false;
            this.grpListadoEmpleados.Text = "Consulta de empleado";
            // 
            // grpInformacion
            // 
            this.grpInformacion.Controls.Add(this.label4);
            this.grpInformacion.Controls.Add(this.lblSueldo);
            this.grpInformacion.Controls.Add(this.label2);
            this.grpInformacion.Controls.Add(this.lblCodigo);
            this.grpInformacion.Controls.Add(this.label1);
            this.grpInformacion.Controls.Add(this.lblCategoria);
            this.grpInformacion.Location = new System.Drawing.Point(9, 163);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(217, 192);
            this.grpInformacion.TabIndex = 8;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Informacion del empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoria:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(66, 126);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(100, 23);
            this.lblSueldo.TabIndex = 5;
            this.lblSueldo.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(66, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(100, 23);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = " ";
            this.lblCodigo.Click += new System.EventHandler(this.lblCantidadEmpleados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sueldo:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(80, 76);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(100, 23);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = " ";
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(92, 46);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(134, 21);
            this.cmbEmpleados.TabIndex = 7;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(6, 46);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(80, 16);
            this.lblNombres.TabIndex = 6;
            this.lblNombres.Text = "Empleados:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Enabled = false;
            this.btnConsultar.Location = new System.Drawing.Point(9, 103);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(217, 37);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmConsultaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 489);
            this.Controls.Add(this.grpListadoEmpleados);
            this.Name = "frmConsultaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de datos de un empleado";
            this.Load += new System.EventHandler(this.frmConsultaEmpleado_Load);
            this.grpListadoEmpleados.ResumeLayout(false);
            this.grpListadoEmpleados.PerformLayout();
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListadoEmpleados;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSueldo;
    }
}