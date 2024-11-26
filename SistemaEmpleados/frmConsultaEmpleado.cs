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
    public partial class frmConsultaEmpleado : Form
    {
        public frmConsultaEmpleado()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            for (Int32 i = 0; i < Vector.IND; i++)
            {
                if (Vector.Empleado[i].Nombre == cmbEmpleados.Text)
                {
                    lblCodigo.Text = Vector.Empleado[i].Codigo.ToString();
                    lblSueldo.Text = Vector.Empleado[i].Sueldo.ToString();
                    lblCategoria.Text = Vector.Empleado[i].Categoria.ToString();
                    return;
                }
            }
        }

        private void lblCantidadEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultaEmpleado_Load(object sender, EventArgs e)
        {

            cmbEmpleados.Items.Clear();

            for (Int32 i = 0; i < Vector.IND; i++)
            {
                if (Vector.Empleado[i].Codigo != 0)
                {
                    cmbEmpleados.Items.Add(Vector.Empleado[i].Nombre);
                }
            }
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEmpleados.Text != "")
            {
                btnConsultar.Enabled = true;
            }
            else
            {
                btnConsultar.Enabled = false;

            }
        }
    }
}
