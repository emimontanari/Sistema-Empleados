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
    public partial class frmListadoEmpleadoSueldo : Form
    {
        public frmListadoEmpleadoSueldo()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dvgListado.Rows.Clear();
            Int32 totalSueldo = 0;
            Int32 totalEmpleados = 0;
            Int32 sueldoMinimo = Convert.ToInt32(txtSueldo.Text);

            for (Int32 i = 0; i < Vector.IND; i++)
            {
                if (Vector.Empleado[i].Sueldo >= sueldoMinimo)
                {
                    dvgListado.Rows.Add(Vector.Empleado[i].Codigo, Vector.Empleado[i].Nombre, Vector.Empleado[i].Sueldo, Vector.Empleado[i].Categoria);
                    totalSueldo += Convert.ToInt32(Vector.Empleado[i].Sueldo);
                    totalEmpleados++;
                }
            }
            if (totalEmpleados == 0)
            {
                MessageBox.Show("No existen empleados con un sueldo mayor o igual al ingresado.");
                txtSueldo.Text = ""; 
                return;
            }
            lblTotalSueldo.Text = totalSueldo.ToString();
            lblCantidadEmpleados.Text = totalEmpleados.ToString();
        }


        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            if (txtSueldo.Text == "")
            {
                btnListar.Enabled = false;
            }
            else
            {
                btnListar.Enabled = true;
            }

        }
    }
}
