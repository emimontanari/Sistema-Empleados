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
    public partial class frmBusquedaEmpleado : Form
    {
        public frmBusquedaEmpleado()
        {
            InitializeComponent();
        }

        private void txtCodigoEmpleado_TextChanged(object sender, EventArgs e)
        {
            if(txtCodigoEmpleado.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 Codigo = Convert.ToInt32(txtCodigoEmpleado.Text);

            for (Int32 i = 0; i < Vector.IND; i++)
            {
                if (Vector.Empleado[i].Codigo == Codigo)
                {
                    lblCodigo.Text = Vector.Empleado[i].Codigo.ToString();
                    lblNombre.Text = Vector.Empleado[i].Nombre;
                    lblSueldo.Text = Vector.Empleado[i].Sueldo.ToString();
                    lblCategoria.Text = Vector.Empleado[i].Categoria.ToString();
                    return;
                }
            }
            MessageBox.Show("Empleado no encontrado");
            txtCodigoEmpleado.Text = "";
            lblCategoria.Text = "";
            lblCodigo.Text = "";
            lblNombre.Text = "";
            lblSueldo.Text = "";
        }

    }
    }
