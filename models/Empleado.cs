using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_Empleados.models
{
    public class Empleado
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroDeIdentificacion { get; set; }
        public byte Edad { get; set; }
        public string Posicion { get; set; }
        public double Salario { get; set; }

        public Empleado(string nombre, string apellido, string numeroDeDocumento, byte edad, string posicion, double salario)
        {
            Id  = Guid.NewGuid();
            Nombre = nombre;
            Apellido = apellido;
            NumeroDeIdentificacion = numeroDeDocumento;
            Edad = edad;
            Posicion = posicion;
            Salario = salario;
        }

        
    }
}