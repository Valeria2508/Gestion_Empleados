using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_Empleados.models
{
    public class Persona
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NumeroDeIdentificacion { get; set; }
        public byte Edad { get; set; }
    }
}