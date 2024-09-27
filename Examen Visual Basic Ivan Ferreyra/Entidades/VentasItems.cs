using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Entidades
{
    class VentasItems
    {
        private int Id_VenItem;
        private int Id_Venta_VenItem;
        private int Id_Producto_VenItem;
        private float PrecioUnitario_VenItem;
        private float Cantidad_VenItem;
        private float PrecioTotal_VenItem;

        public VentasItems()
        {
        }

        public int Id_VenItem1 { get => Id_VenItem; set => Id_VenItem = value; }
        public int Id_Venta_VenItem1 { get => Id_Venta_VenItem; set => Id_Venta_VenItem = value; }
        public int Id_Producto_VenItem1 { get => Id_Producto_VenItem; set => Id_Producto_VenItem = value; }
        public float PrecioUnitario_VenItem1 { get => PrecioUnitario_VenItem; set => PrecioUnitario_VenItem = value; }
        public float Cantidad_VenItem1 { get => Cantidad_VenItem; set => Cantidad_VenItem = value; }
        public float PrecioTotal_VenItem1 { get => PrecioTotal_VenItem; set => PrecioTotal_VenItem = value; }
    }
}
