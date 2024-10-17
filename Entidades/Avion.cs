using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones.Entidades
{
    public class RegistrarAvion
    {
        public string Modelo { get; set; }
        public string Matricula { get; set; }
        public int CapacidadPasajeros { get; set; }

        public override string ToString()
        {
            return Modelo; // O puedes usar Matricula o cualquier otra propiedad que tenga sentido
        }
    }
}


