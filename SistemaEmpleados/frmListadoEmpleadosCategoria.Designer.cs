namespace SistemaEmpleados
{
    partial class frmListadoEmpleadosCategoria
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
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblCantidadEmpleados = new System.Windows.Forms.Label();
            this.lblTotalSueldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgListado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpListadoEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListado)).BeginInit();
            this.SuspendLayout();
            // 
            // grpListadoEmpleados
            // 
            this.grpListadoEmpleados.Controls.Add(this.txtCategoria);
            this.grpListadoEmpleados.Controls.Add(this.lblCategoria);
            this.grpListadoEmpleados.Controls.Add(this.btnListar);
            this.grpListadoEmpleados.Controls.Add(this.lblCantidadEmpleados);
            this.grpListadoEmpleados.Controls.Add(this.lblTotalSueldo);
            this.grpListadoEmpleados.Controls.Add(this.label2);
            this.grpListadoEmpleados.Controls.Add(this.label1);
            this.grpListadoEmpleados.Controls.Add(this.dvgListado);
            this.grpListadoEmpleados.Location = new System.Drawing.Point(24, 12);
            this.grpListadoEmpleados.Name = "grpListadoEmpleados";
            this.grpListadoEmpleados.Size = new System.Drawing.Size(752, 450);
            this.grpListadoEmpleados.TabIndex = 1;
            this.grpListadoEmpleados.TabStop = false;
            this.grpListadoEmpleados.Text = "Listado de empleados por categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(81, 46);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 7;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(6, 46);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 16);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria:";
            // 
            // btnListar
            // 
            this.btnListar.Enabled = false;
            this.btnListar.Location = new System.Drawing.Point(9, 96);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(172, 37);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblCantidadEmpleados
            // 
            this.lblCantidadEmpleados.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCantidadEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadEmpleados.Location = new System.Drawing.Point(164, 396);
            this.lblCantidadEmpleados.Name = "lblCantidadEmpleados";
            this.lblCantidadEmpleados.Size = new System.Drawing.Size(100, 23);
            this.lblCantidadEmpleados.TabIndex = 4;
            this.lblCantidadEmpleados.Text = " ";
            // 
            // lblTotalSueldo
            // 
            this.lblTotalSueldo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSueldo.Location = new System.Drawing.Point(164, 359);
            this.lblTotalSueldo.Name = "lblTotalSueldo";
            this.lblTotalSueldo.Size = new System.Drawing.Size(100, 23);
            this.lblTotalSueldo.TabIndex = 3;
            this.lblTotalSueldo.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de empleados:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Sueldos:";
            // 
            // dvgListado
            // 
            this.dvgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dvgListado.Location = new System.Drawing.Point(6, 170);
            this.dvgListado.Name = "dvgListado";
            this.dvgListado.Size = new System.Drawing.Size(729, 175);
            this.dvgListado.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sueldo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Categoria";
            this.Column4.Name = "Column4";
            // 
            // frmListadoEmpleadosCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 485);
            this.Controls.Add(this.grpListadoEmpleados);
            this.Name = "frmListadoEmpleadosCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de empleados por categoria";
            this.grpListadoEmpleados.ResumeLayout(false);
            this.grpListadoEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListadoEmpleados;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblCantidadEmpleados;
        private System.Windows.Forms.Label lblTotalSueldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
    }
}