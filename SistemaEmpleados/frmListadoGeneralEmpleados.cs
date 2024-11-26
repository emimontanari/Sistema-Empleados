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
    public partial class frmListadoGeneralEmpleados : Form
    {
        public frmListadoGeneralEmpleados()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            dvgListado.Rows.Clear();
            Int32 totalSueldo = 0;
            Int32 totalEmpleados = 0;

            for (int i = 0; i < Vector.IND; i++)
            {
                if (Vector.Empleado[i].Codigo != 0)
                {
                    dvgListado.Rows.Add(Vector.Empleado[i].Codigo, Vector.Empleado[i].Nombre, Vector.Empleado[i].Sueldo, Vector.Empleado[i].Categoria);
                }




                totalSueldo += Convert.ToInt32(Vector.Empleado[i].Sueldo);
                totalEmpleados++;

            }

            lblTotalSueldo.Text = totalSueldo.ToString();

            lblCantidadEmpleados.Text = totalEmpleados.ToString();

        }

        private void frmListadoGeneralEmpleados_Load(object sender, EventArgs e)
        {


        }
    }
}
