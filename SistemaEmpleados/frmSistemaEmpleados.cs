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
    public partial class frmSistemaEmpleados : Form
    {
        public frmSistemaEmpleados()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercade frmACercade = new frmAcercade();

            frmACercade.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarNuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoEmpleado frmNuevoEmpleado = new frmNuevoEmpleado();

            frmNuevoEmpleado.ShowDialog();
        }

        private void frmSistemaEmpleados_Load(object sender, EventArgs e)
        {

            Vector.Empleado[Vector.IND].Codigo = 1;
            Vector.Empleado[Vector.IND].Nombre = "Juan";
            Vector.Empleado[Vector.IND].Sueldo = 1000;
            Vector.Empleado[Vector.IND].Categoria = 1;
            Vector.IND++;

            Vector.Empleado[Vector.IND].Codigo = 2;
            Vector.Empleado[Vector.IND].Nombre = "Pedro";
            Vector.Empleado[Vector.IND].Sueldo = 2000;
            Vector.Empleado[Vector.IND].Categoria = 2;
            Vector.IND++;

            Vector.Empleado[Vector.IND].Codigo = 3;
            Vector.Empleado[Vector.IND].Nombre = "Maria";
            Vector.Empleado[Vector.IND].Sueldo = 3000;
            Vector.Empleado[Vector.IND].Categoria = 3;
            Vector.IND++;

            Vector.Empleado[Vector.IND].Codigo = 4;
            Vector.Empleado[Vector.IND].Nombre = "Ana";
            Vector.Empleado[Vector.IND].Sueldo = 4000;
            Vector.Empleado[Vector.IND].Categoria = 3;
            Vector.IND++;
            Vector.Empleado[Vector.IND].Codigo = 5;
            Vector.Empleado[Vector.IND].Nombre = "Dafne";
            Vector.Empleado[Vector.IND].Sueldo = 1500;
            Vector.Empleado[Vector.IND].Categoria = 3;
            Vector.IND++;
            Vector.Empleado[Vector.IND].Codigo = 6;
            Vector.Empleado[Vector.IND].Nombre = "Emiliano";
            Vector.Empleado[Vector.IND].Sueldo = 4000;
            Vector.Empleado[Vector.IND].Categoria = 1;
            Vector.IND++;
        }

        private void listadoGeneralDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoGeneralEmpleados frmListadoGeneralEmpleados = new frmListadoGeneralEmpleados();

            frmListadoGeneralEmpleados.ShowDialog();
        }

        private void listadoDeEnokeadisDeUnaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmListadoEmpleadosCategoria frmListadoEmpleadosCategoria = new frmListadoEmpleadosCategoria();

            frmListadoEmpleadosCategoria.ShowDialog();

        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoEmpleadoSueldo frmListadoEmpleadoSueldo = new frmListadoEmpleadoSueldo();

            frmListadoEmpleadoSueldo.ShowDialog();
        }

        private void consultaDeDatosDeUnEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEmpleado frmConsultaEmpleado = new frmConsultaEmpleado();

            frmConsultaEmpleado.ShowDialog();
        }

        private void busquedaDeUnEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaEmpleado frmBusquedaEmpleado = new frmBusquedaEmpleado();

            frmBusquedaEmpleado.ShowDialog();
        }
    }
}
