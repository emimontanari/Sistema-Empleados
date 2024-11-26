using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpleados
{
    public partial class frmListarTotalProducidoPorEmpleado : Form
    {
        public frmListarTotalProducidoPorEmpleado()
        {
            InitializeComponent();
        }

        private void cmbListar_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView antes de llenarlo
            dgvEmpleado.Rows.Clear();

            // Recorrer cada empleado
            for (int i = 0; i < Vector.Empleados.Length; i++)
            {
                int totalProducido = 0;

                // Calcular el total producido por el empleado
                for (int j = 0; j < Vector.Maquinas.Length; j++)
                {
                    totalProducido += Matriz.CantidadProducida[i, j];
                }

                // Agregar el nombre del empleado y el total producido al DataGridView
                dgvEmpleado.Rows.Add(Vector.Empleados[i], totalProducido);
            }



        }
    }
}
