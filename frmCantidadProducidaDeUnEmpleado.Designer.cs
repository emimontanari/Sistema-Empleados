namespace SistemaEmpleados
{
    partial class frmCantidadProducidaDeUnEmpleado
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
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.dgvEmpleadoData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadoData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.Location = new System.Drawing.Point(13, 48);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(186, 37);
            this.lblEmpleados.TabIndex = 0;
            this.lblEmpleados.Text = "Empleados:";
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(206, 48);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(385, 45);
            this.cmbEmpleados.TabIndex = 1;
            // 
            // dgvEmpleadoData
            // 
            this.dgvEmpleadoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadoData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvEmpleadoData.Location = new System.Drawing.Point(20, 160);
            this.dgvEmpleadoData.Name = "dgvEmpleadoData";
            this.dgvEmpleadoData.RowHeadersWidth = 82;
            this.dgvEmpleadoData.RowTemplate.Height = 33;
            this.dgvEmpleadoData.Size = new System.Drawing.Size(1203, 639);
            this.dgvEmpleadoData.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Maquina";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(20, 830);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(393, 105);
            this.cmdListar.TabIndex = 3;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // frmCantidadProducidaDeUnEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 1242);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.dgvEmpleadoData);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.lblEmpleados);
            this.Name = "frmCantidadProducidaDeUnEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar cantidad producida de un empleado";
            this.Load += new System.EventHandler(this.frmCantidadProducidaDeUnEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadoData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.DataGridView dgvEmpleadoData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button cmdListar;
    }
}