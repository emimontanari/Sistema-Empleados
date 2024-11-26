namespace SistemaEmpleados
{
    partial class frmListarTotalProducidoPorEmpleado
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
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvEmpleado.Location = new System.Drawing.Point(13, 113);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.RowHeadersWidth = 82;
            this.dgvEmpleado.RowTemplate.Height = 33;
            this.dgvEmpleado.Size = new System.Drawing.Size(1643, 669);
            this.dgvEmpleado.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Empleado";
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
            // cmbListar
            // 
            this.cmbListar.Location = new System.Drawing.Point(13, 874);
            this.cmbListar.Name = "cmbListar";
            this.cmbListar.Size = new System.Drawing.Size(514, 124);
            this.cmbListar.TabIndex = 1;
            this.cmbListar.Text = "Listar";
            this.cmbListar.UseVisualStyleBackColor = true;
            this.cmbListar.Click += new System.EventHandler(this.cmbListar_Click);
            // 
            // frmListarTotalProducidoPorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 1355);
            this.Controls.Add(this.cmbListar);
            this.Controls.Add(this.dgvEmpleado);
            this.Name = "frmListarTotalProducidoPorEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar total producido por cada empleado..";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button cmbListar;
    }
}