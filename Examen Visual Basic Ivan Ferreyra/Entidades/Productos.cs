using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Entidades
{
    class Productos
    {
        private int Id_Pro;
        private String Nombre_Pro;
        private float Precio_Pro;
        private String Categoria_Pro;

        public Productos()
        {
        }

        public int Id_Pro1 { get => Id_Pro; set => Id_Pro = value; }
        public string Nombre_Pro1 { get => Nombre_Pro; set => Nombre_Pro = value; }
        public float Precio_Pro1 { get => Precio_Pro; set => Precio_Pro = value; }
        public string Categoria_Pro1 { get => Categoria_Pro; set => Categoria_Pro = value; }
    }
}
