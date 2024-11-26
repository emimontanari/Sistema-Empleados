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
    public partial class SistemaDeEmpleados : Form
    {
        public SistemaDeEmpleados()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe frmAcercaDe = new frmAcercaDe();
            frmAcercaDe.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void cargaAutomaticaDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cargar empleados en el vector de empleados
            Vector.Empleados[0] = "Garcia, Leonardo";
            Vector.Empleados[1] = "Perez, David";
            Vector.Empleados[2] = "Fernández, Franco";
            Vector.Empleados[3] = "Carrizo, Alejandra";
            Vector.Empleados[4] = "Ortega, Marina";

            // Cargar máquinas en el vector de máquinas
            Vector.Maquinas[0] = "GH-156";
            Vector.Maquinas[1] = "JM-25-80";
            Vector.Maquinas[2] = "ZK-1900";

            // Generador de números aleatorios
            Random r = new Random();

            // Llenar la matriz CantidadProducida con valores aleatorios entre 0 y 100
            for (int f = 0; f < Vector.Empleados.Length; f++)
            {
                for (int c = 0; c < Vector.Maquinas.Length; c++)
                {
                    Matriz.CantidadProducida[f, c] = r.Next(0, 101);
                }
            }

            MessageBox.Show("Los datos se cargaron correctamente!", "Éxito");

        }

        private void consultarCantidadProducidaDeUnEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCantidadProducidaDeUnEmpleado frmCantidadProducidaDeUnEmpleado = new frmCantidadProducidaDeUnEmpleado();
            frmCantidadProducidaDeUnEmpleado.ShowDialog();



        }

        private void listarTotalProducidoEnCadaMaquinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmListarTotalProducidoPorEmpleado frmListarTotalProducidoPorEmpleado = new frmListarTotalProducidoPorEmpleado();

            frmListarTotalProducidoPorEmpleado.ShowDialog();
        }
    }
}
