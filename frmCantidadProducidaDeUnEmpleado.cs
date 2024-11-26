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
    public partial class frmCantidadProducidaDeUnEmpleado : Form
    {
        public frmCantidadProducidaDeUnEmpleado()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
  
            Int32 indiceEmpleado = cmbEmpleados.SelectedIndex;
            dgvEmpleadoData.Rows.Clear();
            if (indiceEmpleado == -1)
            {
                MessageBox.Show("Por favor, seleccione un empleado.");
                return;
            }

            for (int j = 0; j < Vector.Maquinas.Length; j++)
            {
                int cantidadProducida = Matriz.CantidadProducida[indiceEmpleado, j];
                string maquina = Vector.Maquinas[j];
                dgvEmpleadoData.Rows.Add(maquina, cantidadProducida);
            }


        }


        private void frmCantidadProducidaDeUnEmpleado_Load(object sender, EventArgs e)
        {
            cmbEmpleados.Items.Clear();

            if (Vector.Empleados == null || Vector.Empleados.Length == 0 || Vector.Empleados[0] == null)
            {
                MessageBox.Show("No hay empleados en el sistema. Por favor, vaya a Sistema → Carga Automatica de Datos.", "Error");
                cmbEmpleados.Enabled = false;
                cmdListar.Enabled = false;
                return;
            }

            for (int i = 0; i < Vector.Empleados.Length; i++)
            {
                cmbEmpleados.Items.Add(Vector.Empleados[i].ToString());
            }

            cmbEmpleados.SelectedIndex = 0;
        }

    }
}
