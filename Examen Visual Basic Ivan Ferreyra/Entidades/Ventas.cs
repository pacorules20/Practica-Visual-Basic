using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Entidades
{
    class Ventas
    {
        private int Id_Ven;
        private int Id_Clientes_Ven;
        private DateTime Fecha_Ven;
        private float Total_Ven;

        public Ventas(int id_Ven, int id_Clientes_Ven, DateTime fecha_Ven, float total_Ven)
        {
            Id_Ven1 = id_Ven;
            Id_Clientes_Ven1 = id_Clientes_Ven;
            Fecha_Ven1 = fecha_Ven;
            Total_Ven1 = total_Ven;
        }

        public int Id_Ven1 { get => Id_Ven; set => Id_Ven = value; }
        public int Id_Clientes_Ven1 { get => Id_Clientes_Ven; set => Id_Clientes_Ven = value; }
        public DateTime Fecha_Ven1 { get => Fecha_Ven; set => Fecha_Ven = value; }
        public float Total_Ven1 { get => Total_Ven; set => Total_Ven = value; }
    }
}
