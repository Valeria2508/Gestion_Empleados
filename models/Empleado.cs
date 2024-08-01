using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_Empleados.models
{
    public class Empleado:Persona
    {
        // atributos de empleado
        public string? Posicion { get; set; }
        public decimal Salario { get; set; }


        public Empleado(string nombre, string apellido, string numeroDeDocumento, byte edad, string posicion, decimal salario)
        {
            Posicion = posicion;
            Salario = salario;
        }

        private decimal CalcularBonificacion(){
            var Bonificacion = Salario * Convert.ToDecimal(0.01) ;
            var SalarioBonificacion = Bonificacion + Salario;
            return SalarioBonificacion;
        }

        // sobre escritura de metodos
        public override void MostrarInformacion(){
            base.MostrarInformacion();
            Console.WriteLine(@$"
            Posición: {Posicion}
            Salario base: {Salario}
            Salario con Bonificación: {CalcularBonificacion()}
            ");
        }
    }
}