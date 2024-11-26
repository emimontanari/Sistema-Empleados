using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpleados
{
    internal class Vector
    {
        public struct RegEmpleado
        {
            public Int32 Codigo;
            public String Nombre;
            public Decimal Sueldo;
            public Int32 Categoria;
        }

        // Declaración del vector de empleados con un tamaño de 100
        public static RegEmpleado[] Empleado = new RegEmpleado[100];

        // Declaración del índice global para la carga
        public static Int32 IND;

    }
}
