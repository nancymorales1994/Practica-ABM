using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Clientes
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DNI { get; set; }
        public string Cuil { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public override string ToString()
        {
            return Nombre +" "+ Apellido + " " + DNI + " " + Cuil + " " + Direccion + " " + Telefono ;

        }

        public Clientes()
        {

        }

    }

}
