using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Entidades
{
    class Clientes
    {
        private int Id_Cli;
        private String Cliente_Cli;
        private String Telefono_Cli;
        private String Correo_Cli;

        public Clientes()
        {
        }

        public int Id_Cli1 { get => Id_Cli; set => Id_Cli = value; }
        public string Cliente_Cli1 { get => Cliente_Cli; set => Cliente_Cli = value; }
        public string Telefono_Cli1 { get => Telefono_Cli; set => Telefono_Cli = value; }
        public string Correo_Cli1 { get => Correo_Cli; set => Correo_Cli = value; }
    }
}
