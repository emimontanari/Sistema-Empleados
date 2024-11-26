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
    public partial class frmNuevoEmpleado : Form
    {
        public frmNuevoEmpleado()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int nuevoCodigo = Convert.ToInt32(txtCodigo.Text);

            // Validar si el código ya existe
            for (int i = 0; i < Vector.IND; i++)
            {
                if (Vector.Empleado[i].Codigo == nuevoCodigo)
                {
                    MessageBox.Show("El código ya existe");
                    txtCategoria.Text = "";
                    txtNombre.Text = "";
                    txtSalario.Text = "";
                    ObtenerUltimoCodigo();
                    return;
                }
            }


            // Validar si hay espacio para cargar un nuevo empleado
            if (Vector.IND < Vector.Empleado.Length)
            {
                // Agregar los datos del nuevo empleado en el arreglo
                Vector.Empleado[Vector.IND].Codigo = nuevoCodigo;
                Vector.Empleado[Vector.IND].Nombre = txtNombre.Text;
                Vector.Empleado[Vector.IND].Sueldo = Convert.ToDecimal(txtSalario.Text);
                Vector.Empleado[Vector.IND].Categoria = Convert.ToInt32(txtCategoria.Text);
                Vector.IND++;

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtSalario.Text = "";
                txtCategoria.Text = "";

                MessageBox.Show("Empleado cargado correctamente");
            }
            else
            {
                MessageBox.Show("No hay espacio para cargar");
            }
        }

        private void ControlarCajasDeTexto()
        {
            if(txtCategoria.Text != "" && txtCodigo.Text != "" && txtNombre.Text != "" && txtSalario.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }

  
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ControlarCajasDeTexto();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ControlarCajasDeTexto();

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            ControlarCajasDeTexto();

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            ControlarCajasDeTexto();

        }

        private void ObtenerUltimoCodigo()
        {
            //obtener el último código de empleado y sumarle 1 para cargar un nuevo empleado
            int ultimoCodigo = Vector.Empleado[Vector.IND - 1].Codigo;

            txtCodigo.Text = (ultimoCodigo + 1).ToString();

        }
    }
}
